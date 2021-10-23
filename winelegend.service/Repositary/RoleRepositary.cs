using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using winelegend.models;
using winelegend.service.Models;
using winelegend.service.services;

namespace winelegend.service.Repositary
{
    public class RoleRepositary : IRoleService
    {
        private readonly WineLegendContext _dbContext;

        public RoleRepositary()
        {
            this._dbContext = new WineLegendContext();
        }
        public void CreateRole(Role role)
        {
            if (role != null)
                _dbContext.Roles.Add(role);
            _dbContext.SaveChanges();
        }
        public void DeleteRole(Guid id)
        {
            if (id != null)
            {
                var role = _dbContext.Roles.Find(id);
                if (role != null)
                {
                    _dbContext.Roles.Remove(role);
                    _dbContext.SaveChanges();
                }

            }
        }

        public List<winelegend.models.Role> GetAllRoles()
        {
            List<Role> roles = _dbContext.Roles.ToList();
            return roles.ToList();
        }

        public winelegend.models.Role RoleById(Guid id)
        {
            var _role = _dbContext.Roles.Where(x => x.Id == id).SingleOrDefault();
            return _role;
        }

        public Role RoleById(Guid id, Role role)
        {
            throw new NotImplementedException();
        }

        public void UpdateRole(Guid id, Role role)
        {
            Role roles = _dbContext.Roles.Where(x => x.Id == id).SingleOrDefault();
            {
                if (roles != null)
                {
                    roles.Name = role.Name;
                    roles.Description = role.Description;
                    roles.ModifiedBy = "supritha";
                    roles.ModifiedOn = DateTime.Now;
                }
            }
            _dbContext.SaveChanges();

        }

        
    }
}


   