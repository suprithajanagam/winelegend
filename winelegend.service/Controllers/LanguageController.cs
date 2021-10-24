using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using winelegend.models;
using winelegend.service.Services;

namespace winelegend.service.Controllers
{
    public class LanguageController : ApiController
    {
        private ILanguageService _languageService;
        public LanguageController(ILanguageService languageService)
        {
            this._languageService = languageService;
        }

        public IEnumerable<Language> Get()
        {
            return _languageService.GetAll();
        }
    }
}
