using System;
using System.Collections.Generic;
using System.Text;
using Acme.StudentManagementSystem.Localization;
using Volo.Abp.Application.Services;

namespace Acme.StudentManagementSystem;

/* Inherit your application services from this class.
 */
public abstract class StudentManagementSystemAppService : ApplicationService
{
    protected StudentManagementSystemAppService()
    {
        LocalizationResource = typeof(StudentManagementSystemResource);
    }
}
