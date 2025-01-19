using Acme.StudentManagementSystem.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.StudentManagementSystem.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class StudentManagementSystemController : AbpControllerBase
{
    protected StudentManagementSystemController()
    {
        LocalizationResource = typeof(StudentManagementSystemResource);
    }
}
