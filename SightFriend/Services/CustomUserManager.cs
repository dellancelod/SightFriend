using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SightFriend.Data;

namespace SightFriend.Services
{
    public class CustomUserManager : UserManager<IdentityUser>
    {
        private readonly UserStore<IdentityUser, IdentityRole, AppDbContext, string, IdentityUserClaim<string>,
        IdentityUserRole<string>, IdentityUserLogin<string>, IdentityUserToken<string>, IdentityRoleClaim<string>>
        _store;

        public CustomUserManager(IUserStore<IdentityUser> store, 
            IOptions<IdentityOptions> optionsAccessor, 
            IPasswordHasher<IdentityUser> passwordHasher,
            IEnumerable<IUserValidator<IdentityUser>> userValidators, 
            IEnumerable<IPasswordValidator<IdentityUser>> passwordValidators, 
            ILookupNormalizer keyNormalizer, IdentityErrorDescriber errors, 
            IServiceProvider services, ILogger<UserManager<IdentityUser>> logger) 
            : base(store, optionsAccessor, passwordHasher, userValidators, passwordValidators, keyNormalizer, errors, services, logger)
        {
            _store = (UserStore<IdentityUser, IdentityRole, AppDbContext, string, IdentityUserClaim<string>,
            IdentityUserRole<string>, IdentityUserLogin<string>, IdentityUserToken<string>, IdentityRoleClaim<string>>) store;
        }
        public virtual Task<IdentityUser> FindByPhoneNumberAsync(string PhoneNumber, CancellationToken cancellationToken = default(CancellationToken))
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();
            return Users.FirstOrDefaultAsync(u => u.PhoneNumber == PhoneNumber, cancellationToken);
        }
    }
}
