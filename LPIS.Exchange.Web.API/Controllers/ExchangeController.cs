using LPIS.Exchange.Web.Domain.Interfaces;
using LPIS.Exchange.Web.Domain.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LPIS.Exchange.Web.API.Controllers
{
    [Produces("application/json")]
    [Route("exchange")]
    public class ExchangeController : BaseApiController
    {
        #region private interfaces
        private readonly IExchangeService _exchangeService;
        private readonly ICurrencyProviderService _currencyProviderService;
        #endregion
        public ExchangeController(ICurrencyProviderService currencyProviderService, IExchangeService exchangeService,
            ILogger<ExchangeController> logger) : base(logger)
        {
            _currencyProviderService = currencyProviderService;
            _exchangeService = exchangeService;
        }

        [HttpGet]
        [Route("currency")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                IList<Currency> currencies = await _currencyProviderService.GetAll();
                if (currencies.Count > 0)
                {
                    return Json(currencies);
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, null, null);

                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }

            return BadRequest();
        }

        [HttpGet]
        [Route("convert/{amount}/{from}/{to}")]
        public async Task<IActionResult> GetAmount(double amount, string from, string to)
        {
            try
            {
                double total = await _exchangeService.GetTotalAmount(amount, from.ToLower(), to.ToLower());
                if (total > 0)
                {
                    return Ok(total);
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, null, null);

                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }

            return BadRequest();
        }

    }
}