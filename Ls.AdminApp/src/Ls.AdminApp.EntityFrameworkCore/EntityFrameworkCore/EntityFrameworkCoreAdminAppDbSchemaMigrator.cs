using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Ls.AdminApp.Data;
using Volo.Abp.DependencyInjection;

namespace Ls.AdminApp.EntityFrameworkCore;

public class EntityFrameworkCoreAdminAppDbSchemaMigrator
    : IAdminAppDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreAdminAppDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the AdminAppDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<AdminAppDbContext>()
            .Database
            .MigrateAsync();
    }
}
