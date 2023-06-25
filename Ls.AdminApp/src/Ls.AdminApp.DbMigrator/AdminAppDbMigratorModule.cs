using Ls.AdminApp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Ls.AdminApp.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AdminAppEntityFrameworkCoreModule),
    typeof(AdminAppApplicationContractsModule)
    )]
public class AdminAppDbMigratorModule : AbpModule
{

}
