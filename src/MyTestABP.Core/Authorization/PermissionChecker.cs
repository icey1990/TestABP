using Abp.Authorization;
using MyTestABP.Authorization.Roles;
using MyTestABP.Authorization.Users;

namespace MyTestABP.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
