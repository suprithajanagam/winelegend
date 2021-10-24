using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
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
        [ResponseType(typeof(Language))]
        public IHttpActionResult GetLanguage(Guid id)
        {
            Language language = _languageService.GetById(id);
            if (language == null)
            {
                return NotFound();
            }

            return Ok(language);
        }
        // PUT: api/Language/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutLanguage(Guid id, Language language)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != language.Id)
            {
                return BadRequest();
            }



            try
            {
                _languageService.Update(id, language);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LanguageExists(id))
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
        // POST: api/Language
        [ResponseType(typeof(Language))]
        public IHttpActionResult PostLanguages(Language language)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }



            try
            {
               _languageService.Create(language);
            }
            catch (DbUpdateException)
            {
                if (LanguageExists(language.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = language.Id }, language);
        }
        // DELETE: api/Currency/5
        [ResponseType(typeof(Language))]
        public IHttpActionResult DeleteLanguage(Guid id)
        {

            if (id == null)
            {
                return NotFound();
            }

            _languageService.Delete(id);
            Language language = _languageService.GetById(id);

            return Ok(language);
        }
        private bool LanguageExists(Guid id)
        {

            var language = _languageService.GetById(id);

            if (language != null)
                return true;
            else
                return false;
        }
    }
}
