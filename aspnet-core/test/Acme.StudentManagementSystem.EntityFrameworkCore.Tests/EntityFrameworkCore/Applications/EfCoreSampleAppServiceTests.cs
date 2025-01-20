using Acme.StudentManagementSystem.Samples;
using Xunit;

namespace Acme.StudentManagementSystem.EntityFrameworkCore.Applications;

[Collection(StudentManagementSystemTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<StudentManagementSystemEntityFrameworkCoreTestModule>
{

}
