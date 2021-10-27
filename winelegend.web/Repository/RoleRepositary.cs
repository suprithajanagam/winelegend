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
    public class RoleRepositary:IRoleService
    {
        private readonly HttpClient client;
        private readonly string Baseurl = ConfigurationManager.AppSettings["serviceUrl"].ToString();
        public RoleRepositary()
        {
            this.client = new HttpClient();
            client.BaseAddress = new Uri(Baseurl);
            client.DefaultRequestHeaders.Clear();
            //Define request data format
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        internal static Task Add(Role student)
        {
            throw new NotImplementedException();
        }

        public Role Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Role>> Get(string str = "")
        {

            List<Role> roles = new List<Role>();
            HttpResponseMessage Res = await client.GetAsync("api/Role/");
            if (Res.IsSuccessStatusCode)
            {

                var roleResponse = Res.Content.ReadAsStringAsync().Result;
                //Deserializing the response recieved from web api and storing into the Employee list
                roles = JsonConvert.DeserializeObject<List<Role>>(roleResponse);
            }
            //returning the employee list to view
            return roles;
        }

        public void Save(Role role)
        {
            throw new NotImplementedException();
        }

        public void Update(Guid id, Role role)
        {
            throw new NotImplementedException();
        }
    }
}