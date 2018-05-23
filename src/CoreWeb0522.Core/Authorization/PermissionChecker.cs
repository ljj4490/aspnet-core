using Abp.Authorization;
using CoreWeb0522.Authorization.Roles;
using CoreWeb0522.Authorization.Users;

namespace CoreWeb0522.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
