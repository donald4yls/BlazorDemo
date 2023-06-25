using Ls.AdminApp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Ls.AdminApp.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AdminAppController : AbpControllerBase
{
    protected AdminAppController()
    {
        LocalizationResource = typeof(AdminAppResource);
    }
}
