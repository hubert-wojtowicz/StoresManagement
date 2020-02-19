using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StoresManagement.Models
{
    public class Contact
    {
        [Display(Name = "Contact - Entity Id")]
        public int? EntityId { get; set; }

        [Display(Name = "Contact - Entity Object")]
        public int Id { get; set; }

        [Display(Name = "Contact - Address Type")]
        public char? AddressType { get; set; }

        [Display(Name = "Contact - Address Country")]
        public string AddressCountry { get; set; }

        [Display(Name = "Contact - Address PostalCode")]
        public string AddressPostalCode { get; set; }

        [Display(Name = "Contact - Address State")]
        public string AddressState { get; set; }

        [Display(Name = "Contact - Address City")]
        public string AddressCity { get; set; }

        [Display(Name = "Contact - Address Street")]
        public string AddressStreet { get; set; }

        [Display(Name = "Contact - Address Number")]
        public int? AddressNumber { get; set; }

        [Display(Name = "Contact - Address Complement")]
        public string AddressComplement { get; set; }

        [Display(Name = "Contact - Owner Address Type")]
        public char? OwnerAddressType { get; set; }

        [Display(Name = "Contact - Phone Number")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Contact - Email")]
        public string Email { get; set; }

        ////public int CustomerId { get; set; }
        //public virtual Customer Customer { get; set; }

        ////public int BranchId { get; set; }
        //public virtual Branch Branch { get; set; }
    }
}