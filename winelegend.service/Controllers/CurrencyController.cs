using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
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
        [ResponseType(typeof(Currency))]
        public IHttpActionResult GetCurrency(Guid id)
        {
            Currency currency = _currencyService.GetById(id);
            if (currency == null)
            {
                return NotFound();
            }

            return Ok(currency);
        }
        // PUT: api/Currency/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCurrency(Guid id, Currency currency)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != currency.Id)
            {
                return BadRequest();
            }



            try
            {
                _currencyService.Update(id,currency);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CurrencyExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }
        
        // POST: api/Currency
        [ResponseType(typeof(Currency))]
        public IHttpActionResult PostCurrencies(Currency currency)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }



            try
            {
                _currencyService.Create(currency);
            }
            catch (DbUpdateException)
            {
                if (CurrencyExists(currency.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = currency.Id }, currency);
        }
        // DELETE: api/Currency/5
        [ResponseType(typeof(Currency))]
        public IHttpActionResult DeleteCurrency(Guid id)
        {

            if (id == null)
            {
                return NotFound();
            }

            _currencyService.Delete(id);
            Currency currency = _currencyService.GetById(id);

            return Ok(currency);
        }
        private bool CurrencyExists(Guid id)
        {

            var currency = _currencyService.GetById(id);

            if (currency != null)
                return true;
            else
                return false;
        }
    }
}
