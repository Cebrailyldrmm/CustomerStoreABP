using Volo.Abp.Settings;

namespace CustomerStore.Settings;

public class CustomerStoreSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(CustomerStoreSettings.MySetting1));
    }
}
