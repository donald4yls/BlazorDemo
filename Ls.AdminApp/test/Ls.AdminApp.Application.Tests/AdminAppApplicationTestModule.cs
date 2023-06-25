using Volo.Abp.Modularity;

namespace Ls.AdminApp;

[DependsOn(
    typeof(AdminAppApplicationModule),
    typeof(AdminAppDomainTestModule)
    )]
public class AdminAppApplicationTestModule : AbpModule
{

}
