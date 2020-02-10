namespace StoresManagement
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Contact
    {
        public int Id { get; set; }

        public int EntityId { get; set; }

        public string AddressCountry { get; set; }

        public string AddressPostalCode { get; set; }

        public string AddressState { get; set; }

        public string AddressCity { get; set; }

        public string AddressStreet { get; set; }

        public int? AddressNumber { get; set; }

        public string AddressComplement { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public virtual Branch Branch { get; set; }
    }
}
