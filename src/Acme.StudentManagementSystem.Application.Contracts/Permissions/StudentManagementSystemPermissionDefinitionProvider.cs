using Acme.StudentManagementSystem.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Acme.StudentManagementSystem.Permissions;

public class StudentManagementSystemPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(StudentManagementSystemPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(StudentManagementSystemPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<StudentManagementSystemResource>(name);
    }
}
