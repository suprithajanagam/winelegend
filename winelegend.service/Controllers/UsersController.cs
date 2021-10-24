
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using winelegend.models;
using winelegend.service.Models;
using winelegend.service.services;

namespace winelegend.service.Controllers
{
    public class UsersController : ApiController
    {
        private readonly IUserService _userservice;
        public UsersController(IUserService userservice)
        {
            this._userservice = userservice;
        }


        // GET: api/Users
        public List<Users> GetUsers()
        {
            return _userservice.GetAll();
        }

        // GET: api/Users/5
        [ResponseType(typeof(Users))]
        public IHttpActionResult GetUsers(Guid id)
        {
            Users users = _userservice.GetById(id);
            if (users == null)
            {
                return NotFound();
            }

            return Ok(users);
        }
        [Route("api/Users/AuthenticateUser")]
        [ResponseType(typeof(Users))]
        public IHttpActionResult AuthenticateUser(string username, string password)
        {
            Users users = _userservice.AuthenticateUser(username, password);

            if (users == null)
            {
                return NotFound();
            }

            return Ok(users);
        }


        // PUT: api/Users/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutUsers(Guid id, Users users)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != users.Id)
            {
                return BadRequest();
            }



            try
            {
                _userservice.Update(id, users);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsersExists(id))
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

        // POST: api/Users
        [ResponseType(typeof(Users))]
        public IHttpActionResult PostUsers(Users users)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }



            try
            {
                _userservice.Create(users);
            }
            catch (DbUpdateException)
            {
                if (UsersExists(users.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = users.Id }, users);
        }

        // DELETE: api/Users/5
        [ResponseType(typeof(Users))]
        public IHttpActionResult DeleteUsers(Guid id)
        {

            if (id == null)
            {
                return NotFound();
            }

            _userservice.Delete(id);
            Users users = _userservice.GetById(id);

            return Ok(users);
        }

        private bool UsersExists(Guid id)
        {

            var user = _userservice.GetById(id);

            if (user != null)
                return true;
            else
                return false;
        }
    }
}
