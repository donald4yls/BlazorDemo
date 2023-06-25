using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Ls.AdminApp.Blazor;

[Dependency(ReplaceServices = true)]
public class AdminAppBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "AdminApp";
}
