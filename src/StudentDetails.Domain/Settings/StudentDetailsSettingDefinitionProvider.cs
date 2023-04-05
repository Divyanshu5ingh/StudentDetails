using Volo.Abp.Settings;

namespace StudentDetails.Settings;

public class StudentDetailsSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(StudentDetailsSettings.MySetting1));
    }
}
