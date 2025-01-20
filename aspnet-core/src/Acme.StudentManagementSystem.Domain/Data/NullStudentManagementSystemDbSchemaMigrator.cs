using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Acme.StudentManagementSystem.Data;

/* This is used if database provider does't define
 * IStudentManagementSystemDbSchemaMigrator implementation.
 */
public class NullStudentManagementSystemDbSchemaMigrator : IStudentManagementSystemDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
