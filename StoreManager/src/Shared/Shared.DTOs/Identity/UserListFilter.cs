using StoreManager.Shared.DTOs.Filters;

namespace StoreManager.Shared.DTOs.Identity
{
    public class UserListFilter : PaginationFilter
    {
        public bool? IsActive { get; set; }
    }
}