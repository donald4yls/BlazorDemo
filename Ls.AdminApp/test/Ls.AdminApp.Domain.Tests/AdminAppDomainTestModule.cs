using Ls.AdminApp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Ls.AdminApp;

[DependsOn(
    typeof(AdminAppEntityFrameworkCoreTestModule)
    )]
public class AdminAppDomainTestModule : AbpModule
{

}
