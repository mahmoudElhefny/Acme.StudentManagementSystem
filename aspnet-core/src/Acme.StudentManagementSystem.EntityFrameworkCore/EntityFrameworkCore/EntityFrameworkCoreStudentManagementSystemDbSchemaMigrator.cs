using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Acme.StudentManagementSystem.Data;
using Volo.Abp.DependencyInjection;

namespace Acme.StudentManagementSystem.EntityFrameworkCore;

public class EntityFrameworkCoreStudentManagementSystemDbSchemaMigrator
    : IStudentManagementSystemDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreStudentManagementSystemDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the StudentManagementSystemDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<StudentManagementSystemDbContext>()
            .Database
            .MigrateAsync();
    }
}
