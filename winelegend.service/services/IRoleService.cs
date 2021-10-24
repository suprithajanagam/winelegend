using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using winelegend.models;
namespace winelegend.service.services
{
   public interface IRoleService
    {
         void CreateRole(Role role);
         List<winelegend.models.Role> GetAllRoles();
        winelegend.models.Role RoleById(Guid id);
        void UpdateRole(Guid id,Role role);
        void DeleteRole(Guid id);
    }
}
