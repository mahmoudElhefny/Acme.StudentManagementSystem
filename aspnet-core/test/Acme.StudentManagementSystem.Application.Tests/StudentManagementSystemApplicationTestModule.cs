using Volo.Abp.Modularity;

namespace Acme.StudentManagementSystem;

[DependsOn(
    typeof(StudentManagementSystemApplicationModule),
    typeof(StudentManagementSystemDomainTestModule)
)]
public class StudentManagementSystemApplicationTestModule : AbpModule
{

}
