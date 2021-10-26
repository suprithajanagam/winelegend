using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using winelegend.models;
using winelegend.web.Services;

namespace winelegend.web.Repository
{
    public class CurrencyRepositary : ICurrencyService
    {
        private readonly HttpClient client;
        private readonly string BaseUrl= ConfigurationManager.AppSettings["serviceUrl"].ToString();
        public void Delete(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Currency Get(Guid Id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Currency>> Get(string str = "")
        {
            List<Currency> currencies = new List<Currency>();
            HttpResponseMessage Res = await client.GetAsync("api/Currency/");
            if (Res.IsSuccessStatusCode)
            {

                var currencyResponse = Res.Content.ReadAsStringAsync().Result;
                //Deserializing the response recieved from web api and storing into the Employee list
                currencies = JsonConvert.DeserializeObject<List<Currency>>(currencyResponse);
            }
            //returning the employee list to view
            return currencies;
        }

        public void Save(Currency currency)
        {
            throw new NotImplementedException();
        }

        public void Update(Guid Id, Currency currency)
        {
            throw new NotImplementedException();
        }
    }
}