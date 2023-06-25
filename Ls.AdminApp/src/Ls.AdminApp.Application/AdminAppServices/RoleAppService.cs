using Ls.AdminApp.AdminAppContracts;
using Volo.Abp.Identity;

namespace Ls.AdminApp.AdminAppServices
{
    public class RoleAppService : IdentityRoleAppService, IRoleAppService
    {
        public RoleAppService(IdentityRoleManager roleManager, 
            IIdentityRoleRepository roleRepository) 
            : base(roleManager, roleRepository)
        {
        }
    }
}
