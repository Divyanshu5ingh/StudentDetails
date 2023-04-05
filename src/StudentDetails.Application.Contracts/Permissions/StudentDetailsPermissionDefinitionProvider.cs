using StudentDetails.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace StudentDetails.Permissions;

public class StudentDetailsPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(StudentDetailsPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(StudentDetailsPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<StudentDetailsResource>(name);
    }
}
