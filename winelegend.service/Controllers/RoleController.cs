using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
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
        //GET:API/Role
        public List<Role> Index()
        {
            return _roleservice.GetAllRoles();

        }
        [ResponseType(typeof(Role))]
        public IHttpActionResult GetRoles(Guid id)
        {
           Role role = _roleservice.RoleById(id);
            if (role == null)
            {
                return NotFound();
            }

            return Ok(role);
        }
        // PUT: api/Role/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutRoles(Guid id, Role role)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != role.Id)
            {
                return BadRequest();
            }



            try
            {
                _roleservice.UpdateRole(id, role);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RolesExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }
        // POST: api/Role
        [ResponseType(typeof(Role))]
        public IHttpActionResult PostRoles(Role role)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }



            try
            {
                _roleservice.CreateRole(role);
            }
            catch (DbUpdateException)
            {
                if (RolesExists(role.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = role.Id }, role);
        }
        // DELETE: api/Role/5
        [ResponseType(typeof(Role))]
        public IHttpActionResult DeleteRole(Guid id)
        {

            if (id == null)
            {
                return NotFound();
            }

            _roleservice.DeleteRole(id);
            Role role = _roleservice.RoleById(id);

            return Ok(role);
        }


        private bool RolesExists(Guid id)
        {

            var role = _roleservice.RoleById(id);

            if (role != null)
                return true;
            else
                return false;
        }
    }
}

