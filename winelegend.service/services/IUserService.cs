using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winelegend.models;

namespace winelegend.service.services
{
   public interface IUserService
    {
        void Create(Users user);
        List<Users> GetAll();
        Users GetById(Guid id);
        void Update(Guid id, Users users);
        void Delete(Guid id);

        Users AuthenticateUser(string username, string password);
    }
}
