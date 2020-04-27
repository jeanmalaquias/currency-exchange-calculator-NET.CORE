using Microsoft.Extensions.Logging;
using System.Web.Http;

namespace LPIS.Exchange.Web.API.Controllers
{
    public class BaseApiController : ApiController
    {
        protected ILogger logger { get; private set; }

        public BaseApiController(ILogger logger)
        {
            this.logger = logger;
        }
    }

}
