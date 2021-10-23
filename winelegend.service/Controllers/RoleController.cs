using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using winelegend.models;
using winelegend.service.Models;
using winelegend.service.services;

namespace winelegend.service.Controllers
{
    public class RoleController : ApiController
    {
      
        private readonly IRoleService _roleservice;
        

        public RoleController(IRoleService roleservice)
        {
      
            this._roleservice = roleservice;
        }
        //[HttpGet]
        public List<Role> Index()
        {
            return _roleservice.GetAllRoles();
                
        }
        //public ActionResult Create(Role role)
        //{


        //}
    }
}
