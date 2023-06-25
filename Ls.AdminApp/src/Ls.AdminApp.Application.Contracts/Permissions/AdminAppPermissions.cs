namespace Ls.AdminApp.Permissions;

public static class AdminAppPermissions
{
    public const string GroupName = "AdminApp";

    //Add your own permission names. Example:
    //public const string MyPermission1 = GroupName + ".MyPermission1";

    public const string MyPermission1 = GroupName + ".MyPermission1";

    public static class UserManager
    {
        public const string Default = GroupName + ".UserManager";
        public const string Delete = Default + ".Delete";
        public const string Update = Default + ".Update";
        public const string Create = Default + ".Create";
    }

    public static class RoleManager
    {
        public const string Default = GroupName + ".RoleManager";
        public const string Delete = Default + ".Delete";
        public const string Update = Default + ".Update";
        public const string Create = Default + ".Create";
    }
}
