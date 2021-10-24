using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winelegend.models
{
    public class Addresses
    {
        public Addresses()
        {

        }

        [Key]
        public Guid Id { get; set; }

        [ForeignKey("Users")]
        public Guid UserId { get; set; }
        public virtual Users Users { get; set; }
        public string FlotNo { get; set; }
        public string StreetName { get; set; }
        public string LandMark { get; set; }

        public string AddressLineOne { get; set; }
        public string AddressLineTwo { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public string AddressType { get; set; }

        public string PinCode { get; set; }

        public DateTime CreatedOn { get; set; }


        public string CreatedBy { get; set; }

        public DateTime ModifyOn { get; set; }

        public string ModifyBy { get; set; }
    }
}
