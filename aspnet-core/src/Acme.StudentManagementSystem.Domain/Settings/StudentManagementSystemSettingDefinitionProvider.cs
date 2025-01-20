using Volo.Abp.Settings;

namespace Acme.StudentManagementSystem.Settings;

public class StudentManagementSystemSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(StudentManagementSystemSettings.MySetting1));
    }
}
