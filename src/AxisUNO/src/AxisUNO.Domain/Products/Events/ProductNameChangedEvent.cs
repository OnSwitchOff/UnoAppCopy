using BuildingBlocks.Domain.Events;

namespace AxisUNO.Domain.Products.Events;

public record ProductCreatedEvent(Product Product) : DomainEventBase;