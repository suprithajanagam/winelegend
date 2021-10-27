using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.ModelBinding;
using System.Web.Mvc;
using winelegend.models;
using winelegend.web.Services;
using ModelState = System.Web.Mvc.ModelState;

namespace winelegend.web.Repository
{
    public class StudentRepository : IStudentService
    {
        private readonly HttpClient client;
        private readonly string Baseurl = ConfigurationManager.AppSettings["serviceUrl"].ToString();
        public StudentRepository()
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

        internal static Task Add(Student student)
        {
            throw new NotImplementedException();
        }

        public Student Get(Guid Id)
        { 
            throw new NotImplementedException();
        }

        public async Task<List<Student>> Get(string str = "")
        {
            List<Student> stdents = new List<Student>();
            HttpResponseMessage Res = await client.GetAsync("api/Students/");
            if (Res.IsSuccessStatusCode)
            {
                
                var studentResponse = Res.Content.ReadAsStringAsync().Result;
               
                stdents = JsonConvert.DeserializeObject<List<Student>>(studentResponse);
            }
            
            return stdents;
        }

       
          
        public void Update(Guid Id, Student student)
        {
            throw new NotImplementedException();
        }

        public void Save(Student student)
        {
            throw new NotImplementedException();
        }
    }
}