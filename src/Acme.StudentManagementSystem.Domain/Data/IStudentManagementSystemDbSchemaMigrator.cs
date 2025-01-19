using System.Threading.Tasks;

namespace Acme.StudentManagementSystem.Data;

public interface IStudentManagementSystemDbSchemaMigrator
{
    Task MigrateAsync();
}
