using System.Threading.Tasks;

namespace Ls.AdminApp.Data;

public interface IAdminAppDbSchemaMigrator
{
    Task MigrateAsync();
}
