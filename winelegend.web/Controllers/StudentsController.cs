using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;


namespace winelegend.web.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        public ActionResult Index()
        {
            IEnumerable<Student> students = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost/winelegend.service/api");
                //HTTP GET
                var responseTask = client.GetAsync("student");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<Student>>();
                    readTask.Wait();

                    students = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    students = Enumerable.Empty<Student>();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(students);
        }
           
        }

    //internal class Student
    //{
    //}

    //// GET: Students/Details/5
    //public ActionResult Details(int id)
    //    {
    //        return View();
    //    }

    //    // GET: Students/Create
    //    public ActionResult Create()
    //    {
    //        return View();
    //    }

    //    // POST: Students/Create
    //    [HttpPost]
    //    public ActionResult Create(FormCollection collection)
    //    {
    //        try
    //        {
    //            // TODO: Add insert logic here

    //            return RedirectToAction("Index");
    //        }
    //        catch
    //        {
    //            return View();
    //        }
        }

        // GET: Students/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Students/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Students/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Students/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
