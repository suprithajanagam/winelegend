using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using winelegend.web.Services;

namespace winelegend.web.Controllers
{
    public class LanguageController : Controller
    {
        private readonly ILanguageService languageservice;
        public LanguageController(ILanguageService _languageservice)
        {
            this.languageservice = _languageservice;
        }
        // GET: Language
        public async Task<ActionResult> Index()
        {
            var languagelist = await languageservice.Get();
            return View(languagelist);
        }
    }
}