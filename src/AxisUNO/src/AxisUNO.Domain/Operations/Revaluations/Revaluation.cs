using AxisUNO.Domain.Partners;
using AxisUNO.Domain.Payments;
using AxisUNO.Domain.Products;

namespace AxisUNO.Domain.Operations.Revaluations;

public class Revaluation : Operation
{
    protected Revaluation(Partner partner, Payment payment, params OperationProduct[] operationProducts)
        : base(partner, payment, operationProducts)
    {
    }

    public override OperationType OperationType
    {
        get => OperationType.Revaluation;
    }
}