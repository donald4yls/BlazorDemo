using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Ls.AdminApp;

[Dependency(ReplaceServices = true)]
public class AdminAppBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "AdminApp";
}
