using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winelegend.models
{
    public class Language
    {
        public Guid Id { get; set; }
        public string LanguageName { get; set; }
        public string Description { get; set; }
        public string LanguageCode { get; set; }
    }
}
