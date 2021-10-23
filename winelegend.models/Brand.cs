using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winelegend.models
{
    public class Brand
    {
        [Key]
        public Guid BrandId { get; set; }
        //[ForeignKey("SubCategory")]
        public Guid SubCategoryId { get; set; }
        public string BrandName { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }

    }
}
