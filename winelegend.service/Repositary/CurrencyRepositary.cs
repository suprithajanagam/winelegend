using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using winelegend.models;
using winelegend.service.Models;
using winelegend.service.Services;

namespace winelegend.service.Repositary
{
    public class CurrencyRepositary : ICurrencyService
    {
        private readonly WineLegendContext _dbContext;
        public CurrencyRepositary()
        {
            this._dbContext = new WineLegendContext();
        }
        public void Create(Currency currency)
        {
            if(currency!=null)
            {
                _dbContext.Currencies.Add(currency);
                _dbContext.SaveChanges();
            }
        }

        public void Delete(Guid id)
        {
            if(id!=null)
            {
                var currency = _dbContext.Currencies.Find(id);
                if(currency!=null)
                {
                    _dbContext.Currencies.Remove(currency);

                }
                _dbContext.SaveChanges();
            }
        }

        public List<Currency> GetAll()
        {
            var currencies = _dbContext.Currencies.ToList();
            return currencies.ToList();
        }

        public Currency GetById(Guid id)
        {
            var currency = _dbContext.Currencies.Where(x => x.Id == id).SingleOrDefault();
            return currency;
        }

        public void Update(Guid id,Currency currency)
        {
            var _currency = _dbContext.Currencies.Where(x => x.Id == id).SingleOrDefault();
            if(_currency!=null)
            {
                _currency.CurrencyName = currency.CurrencyName;
                _currency.Descrption = currency.Descrption;
            }
            _dbContext.SaveChanges();
        }

        
    }
}