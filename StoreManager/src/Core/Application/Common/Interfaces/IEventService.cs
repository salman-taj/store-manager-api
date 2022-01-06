using StoreManager.Domain.Common.Contracts;

namespace StoreManager.Application.Common.Interfaces
{
    public interface IEventService : ITransientService
    {
        Task PublishAsync(DomainEvent domainEvent);
    }
}