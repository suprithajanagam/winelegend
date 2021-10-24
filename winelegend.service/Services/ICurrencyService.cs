using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winelegend.models;

namespace winelegend.service.Services
{
    public interface ICurrencyService
    {
        void Create(Currency currency);
        List<Currency> GetAll();
        Currency GetById(Guid id);
        void Update(Guid id, Currency currency);
        void Delete(Guid id);
    }
}
