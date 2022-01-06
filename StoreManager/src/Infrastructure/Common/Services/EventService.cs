using MediatR;
using Microsoft.Extensions.Logging;
using StoreManager.Application.Common.Event;
using StoreManager.Application.Common.Interfaces;
using StoreManager.Domain.Common.Contracts;

namespace StoreManager.Infrastructure.Common.Services
{
    public class EventService : IEventService
    {
        private readonly ILogger<EventService> _logger;
        private readonly IPublisher _mediator;

        public EventService(ILogger<EventService> logger, IPublisher mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        public async Task PublishAsync(DomainEvent @event)
        {
            _logger.LogInformation("Publishing Event : {event}", @event.GetType().Name);
            await _mediator.Publish(GetEventNotification(@event));
        }

        private INotification GetEventNotification(DomainEvent @event)
        {
            return (INotification)Activator.CreateInstance(
                typeof(EventNotification<>).MakeGenericType(@event.GetType()), @event)!;
        }
    }
}