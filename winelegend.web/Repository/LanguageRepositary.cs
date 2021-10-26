using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using winelegend.models;
using winelegend.web.Services;

namespace winelegend.web.Repository
{
    public class LanguageRepositary : ILanguageService
    {
        private readonly HttpClient client;
        private readonly string Baseurl = ConfigurationManager.AppSettings["serviceUrl"].ToString();
        public LanguageRepositary()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(Baseurl);
            client.DefaultRequestHeaders.Clear();
            //Define request data format
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        }
        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Role Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Language>> Get(string str = "")
        {

            List<Language> languages = new List<Language>();
            HttpResponseMessage Res = await client.GetAsync("api/Language/");
            
            if (Res.IsSuccessStatusCode)
            {
               
                var languageResponse = Res.Content.ReadAsStringAsync().Result;
                
                languages = JsonConvert.DeserializeObject<List<Language>>(languageResponse);
            }
          
            return languages;
        }

        public void Save(Language language)
        {
            throw new NotImplementedException();
        }

        public void Update(Guid id, Role role)
        {
            throw new NotImplementedException();
        }
    }
}