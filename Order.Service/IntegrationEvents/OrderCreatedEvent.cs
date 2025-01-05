using Order.Service.Infrastructure.EventBus;

namespace Order.Service.IntegrationEvents;

public record  OrderCreatedEvent(string customerId) : Event {}
