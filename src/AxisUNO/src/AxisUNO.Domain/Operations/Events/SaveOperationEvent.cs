using BuildingBlocks.Domain.Events;

namespace AxisUNO.Domain.Operations.Events;

public record SaveOperationEvent(Operation Operation) : DomainEventBase;