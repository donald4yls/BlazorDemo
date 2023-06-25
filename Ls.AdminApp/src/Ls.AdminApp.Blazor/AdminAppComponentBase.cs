using Ls.AdminApp.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Ls.AdminApp.Blazor;

public abstract class AdminAppComponentBase : AbpComponentBase
{
    protected AdminAppComponentBase()
    {
        LocalizationResource = typeof(AdminAppResource);
    }
}
