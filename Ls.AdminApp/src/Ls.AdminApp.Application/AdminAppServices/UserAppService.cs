using Ls.AdminApp.AdminAppContracts;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Volo.Abp.Identity;

namespace Ls.AdminApp.AdminAppServices
{
    public class UserAppService : IdentityUserAppService, IUserAppService
    {
        public UserAppService(IdentityUserManager userManager, 
            IIdentityUserRepository userRepository, 
            IIdentityRoleRepository roleRepository, 
            IOptions<IdentityOptions> identityOptions) 
            : base(userManager, userRepository, roleRepository, identityOptions)
        {
        }
    }
}
