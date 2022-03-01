namespace AxisUNO.Domain.ProductGroups;

public interface IProductGroupRepository
{
    public Task<ProductGroup> GetDefaultAsync();
}