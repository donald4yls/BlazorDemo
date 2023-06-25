using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Ls.AdminApp.Data;

/* This is used if database provider does't define
 * IAdminAppDbSchemaMigrator implementation.
 */
public class NullAdminAppDbSchemaMigrator : IAdminAppDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
