using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using winelegend.models;
using winelegend.service.Models;
using winelegend.service.Services;

namespace winelegend.service.Repositary
{
    public class LanguageRepositary : ILanguageService
    {
        private readonly WineLegendContext _dbContext;
        public LanguageRepositary()
        {
            this._dbContext = new WineLegendContext();
        }
        public void Create(Language language)
        {
            if(language!=null)
            {
                _dbContext.Languages.Add(language);
                _dbContext.SaveChanges();
            }
        }

        public void Delete(Guid id)
        {
            if(id!=null)
            {
                var language = _dbContext.Languages.Find(id);
                if(language!=null)
                {
                    _dbContext.Languages.Remove(language);
                    _dbContext.SaveChanges();

                }
            }
        }

        public List<Language> GetAll()
        {
            var languages = _dbContext.Languages.ToList();
            return languages.ToList();
        }

        public Language GetById(Guid id)
        {
            var language = _dbContext.Languages.Where(x => x.Id == id).SingleOrDefault();
            return language;
        }

        public void Update(Guid id, Language language)
        {
            var _language = _dbContext.Languages.Where(x => x.Id == id).SingleOrDefault();
            if(_language!=null)
            {
                _language.LanguageName = language.LanguageName;
                _language.LanguageCode = language.LanguageCode;
            }
            _dbContext.SaveChanges();

        }
    }
}