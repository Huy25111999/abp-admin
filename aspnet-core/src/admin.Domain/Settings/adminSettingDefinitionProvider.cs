using Volo.Abp.Settings;

namespace admin.Settings;

public class adminSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(adminSettings.MySetting1));
    }
}
