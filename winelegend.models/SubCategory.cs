using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winelegend.models
{
    public class SubCategory
    {
        [ForeignKey("Category")]
        public Guid CategoryId { get; set; }
        [Key]
        public Guid SubCategoryId { get; set; }
        public String SubCategoryName { get; set; }
        public String Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }

    }
}
