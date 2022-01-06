using MediatR;
using Microsoft.Extensions.Logging;
using StoreManager.Application.Common.Event;
using StoreManager.Application.Common.Interfaces;
using StoreManager.Domain.Dashboard;
using StoreManager.Shared.DTOs.Notifications;

namespace StoreManager.Application.Dashboard
{
    public class StatsChangedEventHandler : INotificationHandler<EventNotification<StatsChangedEvent>>
    {
        private readonly ILogger<StatsChangedEventHandler> _logger;
        private readonly INotificationService _notificationService;

        public StatsChangedEventHandler(ILogger<StatsChangedEventHandler> logger, INotificationService notificationService)
        {
            _logger = logger;
            _notificationService = notificationService;
        }

        public async Task Handle(EventNotification<StatsChangedEvent> notification, CancellationToken cancellationToken)
        {
            await _notificationService.SendMessageAsync(new StatsChangedNotification());
            _logger.LogInformation("{event} Triggered", notification.DomainEvent.GetType().Name);
        }
    }
}