using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SightFriend.Data;
using SightFriend.Data.Repo.EntityFramework;
using SightFriend.Data.Repo.Interfaces;
using SightFriend.Services;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

//Add services
builder.Services.AddTransient<ITextFieldsRepository, EFTExtFieldsRepository>();
builder.Services.AddTransient<INewsItemsRepository, EFNewsItemsRepository>();
builder.Services.AddTransient<IBooksItemsRepository, EFBooksItemsRepository>();
builder.Services.AddTransient<DataManager>();

//Connect BD context
builder.Services.AddDbContext<AppDbContext>(options => options
        .UseSqlServer(
            builder.Configuration.GetConnectionString("MSSQLConnectionString")
        )
    );
//builder.Services.AddDbContextPool<AppDbContext>(options => options
//        .UseMySql(
//            builder.Configuration.GetConnectionString("MariaDbConnectionString"),
//            new MariaDbServerVersion(new Version(10, 5, 4))
//        )
//    );

//Configure Identity system
builder.Services.AddIdentity<IdentityUser, IdentityRole>(options =>
{
    options.Password.RequiredLength = 6;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
}).AddEntityFrameworkStores<AppDbContext>()
.AddUserManager<CustomUserManager>()
.AddDefaultTokenProviders();

//Authentication cookies
builder.Services.ConfigureApplicationCookie(options =>
{
    options.Cookie.Name = "mriyaAuth";
    options.Cookie.HttpOnly = true;
    options.LoginPath = "/account/login";
    options.AccessDeniedPath = "/account/accessdenied";
    options.SlidingExpiration = true;
});

//Configure Authorization policy for admin area
builder.Services.AddAuthorization(x =>
{
    x.AddPolicy("AdminArea", policy => { policy.RequireRole("admin"); });
});

// Add services to the container.
builder.Services.AddControllersWithViews(x =>
{
    x.Conventions.Add(new AdminAreaAuthorization("Admin", "AdminArea"));
});

builder.Services.Configure<FormOptions>(options =>
{
    options.MultipartBodyLengthLimit = 512 * 1024 * 1024;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseCookiePolicy();
app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints((endpoints) => {
    endpoints.MapControllerRoute(
        name: "admin",
        pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}"
    );
}
);

app.Run();
