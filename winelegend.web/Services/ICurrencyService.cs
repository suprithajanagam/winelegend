using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winelegend.models;

namespace winelegend.web.Services
{
    public interface ICurrencyService
    {
        void Save(Currency currency);

        void Delete(Guid Id);

        void Update(Guid Id, Currency currency);

        Student Get(Guid Id);

        Task<List<Currency>> Get(string str = "");

    }
}
