using StoreManager.Domain.Common.Contracts;

namespace StoreManager.Domain.Catalog.Events
{
    public class ProductDeletedEvent : DomainEvent
    {
        public ProductDeletedEvent(Product product)
        {
            Product = product;
        }

        public Product Product { get; }
    }
}