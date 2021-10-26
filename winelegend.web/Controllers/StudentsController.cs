using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using winelegend.models;
using winelegend.web.Repository;
using winelegend.web.Services;

namespace winelegend.web.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IStudentService studentService;
        public StudentsController(IStudentService _studentService)
        {
            this.studentService = _studentService;
        }

        public async Task<ActionResult> Index()
        {
            var studentsList = await studentService.Get();

            return View(studentsList);
        }
        [HttpPost]
        [Route("api/Student/Create")]
        public async Task CreateAsync([FromBody] Student student)
        {
            if (ModelState.IsValid)
            {
                await StudentRepository.Add(student);
            }
        }

    }
}
