using Localization.Resources.AbpUi;
using Ls.AdminApp.Localization;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;

namespace Ls.AdminApp;

[DependsOn(
    typeof(AdminAppApplicationContractsModule)
    )]
public class AdminAppHttpApiModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        ConfigureLocalization();
    }

    private void ConfigureLocalization()
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<AdminAppResource>()
                .AddBaseTypes(
                    typeof(AbpUiResource)
                );
        });
    }
}
