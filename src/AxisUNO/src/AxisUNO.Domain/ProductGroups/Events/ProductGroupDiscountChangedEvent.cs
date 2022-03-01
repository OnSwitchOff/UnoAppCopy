using BuildingBlocks.Domain.Events;

namespace AxisUNO.Domain.ProductGroups.Events;

public record ProductGroupDiscountChangedEvent(int ProductGroupId, decimal Discount) : DomainEventBase;