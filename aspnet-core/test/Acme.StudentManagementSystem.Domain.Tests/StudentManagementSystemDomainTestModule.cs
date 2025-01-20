using Volo.Abp.Modularity;

namespace Acme.StudentManagementSystem;

[DependsOn(
    typeof(StudentManagementSystemDomainModule),
    typeof(StudentManagementSystemTestBaseModule)
)]
public class StudentManagementSystemDomainTestModule : AbpModule
{

}
