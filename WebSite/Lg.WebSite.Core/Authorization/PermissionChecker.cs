using Abp.Authorization;
using Lg.WebSite.Authorization.Roles;
using Lg.WebSite.MultiTenancy;
using Lg.WebSite.Users;

namespace Lg.WebSite.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
