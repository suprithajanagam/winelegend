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
using System.Windows.Documents;
using winelegend.models;
using winelegend.service.Models;
using winelegend.service.services;

namespace winelegend.service.Controllers
{
    public class StudentsController : ApiController
    {
        private readonly IStudentService _studentservice;

        public StudentsController(IStudentService studentService)
        {
            this._studentservice = studentService;
        }
        // GET: api/Students
        public IHttpActionResult GetStudents()
        {
            IList<Student> students = null;

            WineLegendContext context = new WineLegendContext();
            students = context.Students.ToList();

            if (students.Count == 0)
            {
                return NotFound();
            }

            return Ok(students);
        }

        // GET: api/Students/5
        [ResponseType(typeof(Student))]
        public IHttpActionResult GetStudent(Guid id)
        {
            Student student = _studentservice.GetStudent(id);
            if (student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }

        // PUT: api/Students/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutStudent(Guid id, Student student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != student.StudentID)
            {
                return BadRequest();
            }



            try
            {
                _studentservice.UpdateStudent(id, student);

            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentExists(id))
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

        // POST: api/Students
        [ResponseType(typeof(Student))]
        public IHttpActionResult PostStudent(Student student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }



            try
            {
                _studentservice.create(student);
            }
            catch (DbUpdateException)
            {
                if (StudentExists(student.StudentID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = student.StudentID }, student);
        }

        // DELETE: api/Students/5
        [ResponseType(typeof(Student))]
        public IHttpActionResult DeleteStudent(Guid id)
        {

            if (id == null)
            {
                return NotFound();
            }

            _studentservice.DeleteStudent(id);

            Student student = _studentservice.GetStudent(id);

            return Ok(student);
        }



        private bool StudentExists(Guid id)
        {
            var student = _studentservice.GetStudent(id);

            if (student != null)
                return true;
            else
                return false;
        }
    }
}