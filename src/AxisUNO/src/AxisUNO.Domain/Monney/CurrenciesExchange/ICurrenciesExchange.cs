namespace AxisUNO.Domain.Monney.CurrenciesExchange;

public interface ICurrenciesExchange
{
    List<ConversionRate> GetConversionRates();
}