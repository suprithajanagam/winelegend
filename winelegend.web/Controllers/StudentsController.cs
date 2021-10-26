
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.ModelBinding;
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
        public ActionResult create()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> create(Student student)
        {
            student.StudentID = Guid.NewGuid();
            student.DateOfBirth = DateTime.Now;

            if (ModelState.IsValid)
            {
                bool valid = await studentService.Save(student);
                if (valid)
                {
                    return RedirectToAction("Index", "Students",  null);
                }
            }
            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");
            
            return View(student);

        }

    }
}
