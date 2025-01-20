using Volo.Abp.Modularity;

namespace Acme.StudentManagementSystem;

public abstract class StudentManagementSystemApplicationTestBase<TStartupModule> : StudentManagementSystemTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
