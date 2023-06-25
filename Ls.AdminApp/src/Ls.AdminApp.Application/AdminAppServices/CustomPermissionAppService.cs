using Ls.AdminApp.AdminAppContracts;
using Microsoft.Extensions.Options;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.PermissionManagement;
using Volo.Abp.SimpleStateChecking;

namespace Ls.AdminApp.AdminAppServices
{
    public class CustomPermissionAppService : PermissionAppService, ICustomPermissionAppService
    {
        public CustomPermissionAppService(
            IPermissionManager permissionManager, 
            IPermissionDefinitionManager permissionDefinitionManager, 
            IOptions<PermissionManagementOptions> options, 
            ISimpleStateCheckerManager<PermissionDefinition> simpleStateCheckerManager) 
            : base(permissionManager, permissionDefinitionManager, options, simpleStateCheckerManager)
        {
        }
    }
}
