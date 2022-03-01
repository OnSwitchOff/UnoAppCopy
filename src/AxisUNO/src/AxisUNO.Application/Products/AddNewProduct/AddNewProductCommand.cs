using BuildingBlocks.Application.Commands;

namespace AxisUNO.Application.Products.AddNewProduct;

public record AddNewProductCommand(string Name, string Code) : CommandBase<int>;