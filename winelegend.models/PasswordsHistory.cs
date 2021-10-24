using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winelegend.models
{
    public class PasswordsHistory
    {
        public Guid Id { get; set; }
        [ForeignKey("Users")]
        public Guid UserId { get; set; }
        public virtual Users Users { get; set; }
        public string  OldPassword { get; set; }
        public string  NewPassword{ get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsActive { get; set; }


    }
}
