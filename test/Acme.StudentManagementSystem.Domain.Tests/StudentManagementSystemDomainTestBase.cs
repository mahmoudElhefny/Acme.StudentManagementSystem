using Volo.Abp.Modularity;

namespace Acme.StudentManagementSystem;

/* Inherit from this class for your domain layer tests. */
public abstract class StudentManagementSystemDomainTestBase<TStartupModule> : StudentManagementSystemTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
