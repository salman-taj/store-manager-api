using MediatR;
using StoreManager.Domain.Common.Contracts;

namespace StoreManager.Application.Common.Event
{
    public class EventNotification<T> : INotification
    where T : DomainEvent
    {
        public EventNotification(T domainEvent)
        {
            DomainEvent = domainEvent;
        }

        public T DomainEvent { get; }
    }
}