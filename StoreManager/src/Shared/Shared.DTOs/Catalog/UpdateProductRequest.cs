using StoreManager.Shared.DTOs.Storage;

namespace StoreManager.Shared.DTOs.Catalog
{
    public class UpdateProductRequest : IMustBeValid
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Rate { get; set; }
        public Guid BrandId { get; set; }
        public FileUploadRequest Image { get; set; }
    }
}