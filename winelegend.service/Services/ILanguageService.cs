using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winelegend.models;

namespace winelegend.service.Services
{
    public interface ILanguageService
    {
        void Create(Language language);
        List<Language> GetAll();
        Language GetById(Guid id);
        void Update(Guid id, Language language);
        void Delete(Guid id);

    }
}
