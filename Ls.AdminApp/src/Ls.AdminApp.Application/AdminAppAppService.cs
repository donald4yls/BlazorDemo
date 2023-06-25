using System;
using System.Collections.Generic;
using System.Text;
using Ls.AdminApp.Localization;
using Volo.Abp.Application.Services;

namespace Ls.AdminApp;

/* Inherit your application services from this class.
 */
public abstract class AdminAppAppService : ApplicationService
{
    protected AdminAppAppService()
    {
        LocalizationResource = typeof(AdminAppResource);
    }
}
