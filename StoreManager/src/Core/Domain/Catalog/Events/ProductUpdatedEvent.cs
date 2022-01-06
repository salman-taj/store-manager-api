using StoreManager.Domain.Common.Contracts;

namespace StoreManager.Domain.Catalog.Events
{
    public class ProductUpdatedEvent : DomainEvent
    {
        public ProductUpdatedEvent(Product product)
        {
            Product = product;
        }

        public Product Product { get; }
    }
}