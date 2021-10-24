using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using winelegend.models;
using winelegend.service.Models;
using winelegend.service.services;

namespace winelegend.service.Repositary
{
  

    
    public class UsersRepositary : IUserService
    {
        private readonly WineLegendContext _dbContext;
        public UsersRepositary()
        {
            this._dbContext = new WineLegendContext();
        }

        public void Create(Users user)
        {
            if(user!=null)
            {
                _dbContext.Users.Add(user);
                _dbContext.SaveChanges();
            }
        }

        

        public void Delete(Guid id)
        {
            if(id!=null)
            {
                var user = _dbContext.Users.Find(id);
                if(user!=null)
                {
                    _dbContext.Users.Remove(user);
                    _dbContext.SaveChanges();
                }
            }
        }

       

        public List<Users> GetAll()
        {
            var users = _dbContext.Users.ToList();
            return users.ToList();
        }   

        public Users GetById(Guid id)
        {
            var user = _dbContext.Users.Where(x => x.Id == id).SingleOrDefault();
            return user;
        }   

        public void Update(Guid id, Users users)
        {
            Users _user = _dbContext.Users.Where(x => x.Id == id).SingleOrDefault();
            if(_user!=null)
            {
                _user.UserName = users.UserName;
                _user.Addresses = users.Addresses;
                _user.Email = users.Email;
                _user.PhoneNumber = users.PhoneNumber;
                _user.EmergencyContactNumber = users.EmergencyContactNumber;
                _user.ModifiedBy = "supritha";
                _user.ModifiedDate = DateTime.Now;
                
            }
            _dbContext.SaveChanges();

        }

       
    }
}