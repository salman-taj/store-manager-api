using StoreManager.Domain.Common.Contracts;

namespace StoreManager.Domain.Catalog.Events
{
    public class ProductCreatedEvent : DomainEvent
    {
        public ProductCreatedEvent(Product product)
        {
            Product = product;
        }

        public Product Product { get; }
    }
}