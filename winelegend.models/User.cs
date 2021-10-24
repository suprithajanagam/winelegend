using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winelegend.models
{
    public class User
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy{get;set;}
        public DateTime ModifiedDate { get; set; }
        public int EmergencyContactNumber { get; set; }
        public string EmergencyContactPersonName { get; set; }




    }
}
