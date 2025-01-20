using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Acme.StudentManagementSystem;

[Dependency(ReplaceServices = true)]
public class StudentManagementSystemBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "StudentManagementSystem";
}
