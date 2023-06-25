using Ls.AdminApp.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Ls.AdminApp.Permissions;

public class AdminAppPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AdminAppPermissions.GroupName);
        //Define your own permissions here. Example:
        myGroup.AddPermission(AdminAppPermissions.MyPermission1, L("Permission:MyPermission1"));

        var userManager = myGroup.AddPermission(AdminAppPermissions.UserManager.Default, L("UserManager"));
        userManager.AddChild(AdminAppPermissions.UserManager.Create, L("Create"));
        userManager.AddChild(AdminAppPermissions.UserManager.Update, L("Edit"));
        userManager.AddChild(AdminAppPermissions.UserManager.Delete, L("Delete"));

        var roleManager = myGroup.AddPermission(AdminAppPermissions.RoleManager.Default, L("RoleManager"));
        roleManager.AddChild(AdminAppPermissions.RoleManager.Create, L("Create"));
        roleManager.AddChild(AdminAppPermissions.RoleManager.Update, L("Edit"));
        roleManager.AddChild(AdminAppPermissions.RoleManager.Delete, L("Delete"));

    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AdminAppResource>(name);
    }
}
