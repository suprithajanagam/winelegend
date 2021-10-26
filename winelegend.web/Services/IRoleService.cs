using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winelegend.models;

namespace winelegend.web.Services
{
   public  interface IRoleService
    {
        void Save(Role role);
        void Delete(Guid id);
        void Update(Guid id, Role role);
        Role Get(Guid id);
        Task<List<Role>> Get(string str = "");
    }
}
