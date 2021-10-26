using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winelegend.models;

namespace winelegend.web.Services
{
    public interface ILanguageService
    {
        void Save(Language language);
        void Delete(Guid id);
        void Update(Guid id, Role role);
        Role Get(Guid id);
        Task<List<Language>> Get(string str = "");
    }
}

