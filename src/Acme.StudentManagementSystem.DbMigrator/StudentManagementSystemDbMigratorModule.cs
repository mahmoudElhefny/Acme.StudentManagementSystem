using Acme.StudentManagementSystem.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Acme.StudentManagementSystem.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(StudentManagementSystemEntityFrameworkCoreModule),
    typeof(StudentManagementSystemApplicationContractsModule)
    )]
public class StudentManagementSystemDbMigratorModule : AbpModule
{
}
