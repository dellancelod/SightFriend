using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SightFriend.Data;
using SightFriend.Data.Repo;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Add services
builder.Services.AddTransient<INewsItemsRepository, EFNewsItemRepository>();
builder.Services.AddTransient<DataManager>();

//Connect BD context
builder.Services.AddDbContextPool<AppDbContext>(options => options
        .UseMySql(
            builder.Configuration.GetConnectionString("MariaDbConnectionString"),
            new MariaDbServerVersion(new Version(10, 5, 4))
        )
    );


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

app.UseAuthorization();

app.UseEndpoints((endpoints) => { 
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}"
    );
}
);

app.Run();
