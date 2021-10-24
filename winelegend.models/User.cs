using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winelegend.models
{

    public class Users
    {
        [Key]
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string EmergencyContactNumber { get; set; }
        public string EmergencyContactPersonName { get; set; }
        public bool IsActive { get; set; }

        public string PasswordHash { get; set; }

        public string PasswordSalt { get; set; }

        public virtual List<Addresses> Addresses { get; set; }
        public virtual List<PasswordsHistory> PasswordsHistories { get; set; }


    }
}
