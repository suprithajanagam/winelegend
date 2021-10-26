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
    public class UsersRepositary : IUserService
    {
        private readonly HttpClient client;
        private readonly string Baseurl = ConfigurationManager.AppSettings["serviceUrl"].ToString();
        public UsersRepositary()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(Baseurl);
            client.DefaultRequestHeaders.Clear();
            //Define request data format
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public void Delete(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Student Get(Guid Id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Users>> Get(string str = "")
        {
            List<Users> users = new List<Users>();
            HttpResponseMessage Res = await client.GetAsync("api/Users/");
            if (Res.IsSuccessStatusCode)
            {

                var userResponse = Res.Content.ReadAsStringAsync().Result;
                //Deserializing the response recieved from web api and storing into the Employee list
                users = JsonConvert.DeserializeObject<List<Users>>(userResponse);
            }
            //returning the employee list to view
            return users;
        }

        public void Save(Users users)
        {
            throw new NotImplementedException();
        }

        public void Update(Guid Id, Users user)
        {
            throw new NotImplementedException();
        }
    }
}