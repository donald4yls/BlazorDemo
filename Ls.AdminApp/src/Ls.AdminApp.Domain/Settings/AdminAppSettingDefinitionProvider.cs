using Volo.Abp.Settings;

namespace Ls.AdminApp.Settings;

public class AdminAppSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(AdminAppSettings.MySetting1));
    }
}
