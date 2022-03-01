using AxisUNO.Domain.Operations;

namespace AxisUNO.Domain.OperationHeaders;

public interface IAcctProvider
{
    int GetNextAcct(OperationType operationType);
}