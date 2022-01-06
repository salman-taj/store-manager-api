using StoreManager.Shared.DTOs.Filters;

namespace StoreManager.Shared.DTOs.Catalog
{
    public class ProductListFilter : PaginationFilter
    {
        public Guid? BrandId { get; set; }
        public decimal? MinimumRate { get; set; }
        public decimal? MaximumRate { get; set; }
    }
}