using Microsoft.AspNetCore.Authorization;

namespace StoreManager.Infrastructure.Identity.Permissions
{
    public class MustHavePermission : AuthorizeAttribute
    {
        public MustHavePermission(string permission)
        {
            Policy = permission;
        }
    }
}