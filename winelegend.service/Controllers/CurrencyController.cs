using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using winelegend.models;
using winelegend.service.Services;

namespace winelegend.service.Controllers
{
    public class CurrencyController : ApiController
    {
        private readonly ICurrencyService _currencyService;
        public CurrencyController(ICurrencyService currencyService)
        {
            this._currencyService = currencyService;
        }

        public IEnumerable<Currency> GetCurrencies()
        {
            return _currencyService.GetAll();
        }

    }
}
