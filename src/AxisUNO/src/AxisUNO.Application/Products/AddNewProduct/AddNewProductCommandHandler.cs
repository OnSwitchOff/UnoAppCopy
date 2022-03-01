using AxisUNO.Application.ProdcutGroups;
using AxisUNO.Domain.ProductGroups;
using AxisUNO.Domain.Products;
using AxisUNO.Domain.Products.Measures;
using BuildingBlocks.Application.Commands;
using HarabaSourceGenerators.Common.Attributes;

namespace AxisUNO.Application.Products.AddNewProduct;

[Inject]
public partial class AddNewProductCommandHandler : ICommandHandler<AddNewProductCommand, int>
{
    private readonly IProductRepository _productRepository;

    public async Task<int> Handle(AddNewProductCommand request, CancellationToken cancellationToken)
    {
        var product = Product.Create(
            "product1",
            ProductGroup.Create("productGroup1", new GroupPathGenerator(), 0),
            new Measure("measure1"),
            code: "code1",
            barcode: "barcode1");

        await _productRepository.AddAsync(product);

        return 1;
    }
}