using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winelegend.models
{
    public class Currency
    { 
        [Key]
        public Guid Id { get; set; }
        [StringLength(50)]
        [Index("CurrencyName", IsUnique = true)]
        public string CurrencyName { get; set; }
        public string Descrption { get; set; }
        [StringLength(10)]
        //[Index("CurrencyCode", IsUnique = true)]
        public string CurrencyCode { get; set; }

    }
}
