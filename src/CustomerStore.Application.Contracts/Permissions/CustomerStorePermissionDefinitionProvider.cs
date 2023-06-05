using CustomerStore.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace CustomerStore.Permissions;

public class CustomerStorePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(CustomerStorePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(CustomerStorePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<CustomerStoreResource>(name);
    }
}
