using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winelegend.models;

namespace winelegend.web.Services
{
    public interface IUserService
    {
        void Save(Users users);

        void Delete(Guid Id);

        void Update(Guid Id, Users user);

        Student Get(Guid Id);

        Task<List<Users>> Get(string str = "");
    }
}
