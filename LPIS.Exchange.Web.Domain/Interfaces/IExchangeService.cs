using System.Collections.Generic;
using System.Threading.Tasks;

namespace LPIS.Exchange.Web.Domain.Interfaces
{
    public interface IExchangeService
    {
        Task<double> GetTotalAmount(double amount, string fromCurrency, string toCurrency);

    }
}
