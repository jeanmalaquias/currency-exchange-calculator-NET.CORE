using LPIS.Exchange.Web.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LPIS.Exchange.Web.Domain.Interfaces
{
    public interface ICurrencyProviderService
    {
        Task<IList<Currency>> GetAll();
    }
}
