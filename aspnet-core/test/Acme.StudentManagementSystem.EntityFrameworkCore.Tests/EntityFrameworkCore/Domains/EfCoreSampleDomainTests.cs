using Acme.StudentManagementSystem.Samples;
using Xunit;

namespace Acme.StudentManagementSystem.EntityFrameworkCore.Domains;

[Collection(StudentManagementSystemTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<StudentManagementSystemEntityFrameworkCoreTestModule>
{

}
