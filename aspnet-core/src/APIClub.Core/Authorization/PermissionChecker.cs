using Abp.Authorization;
using APIClub.Authorization.Roles;
using APIClub.Authorization.Users;

namespace APIClub.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
