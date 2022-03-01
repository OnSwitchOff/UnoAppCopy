using AxisUNO.Domain.Products;
using BuildingBlocks.Domain.BusinessRules;

namespace AxisUNO.Domain.Operations.Rules;

internal class AmountOfProductsCannotBeZeroRule : IBusinessRule
{
    private OperationProduct[] _operationProducts;

    public AmountOfProductsCannotBeZeroRule(OperationProduct[] operationProducts)
    {
        _operationProducts = operationProducts;
    }

    public string Message => "Amount of products can't be zero.";

    public bool BrokenWhen()
    {
        return _operationProducts.Length == 0;
    }
}