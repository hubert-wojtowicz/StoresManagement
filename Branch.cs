namespace StoresManagement
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Branch
    {
        public int Id { get; set; }

        public int EntityId { get; set; }

        public string Identification { get; set; }

        public string Name { get; set; }

        public int ContactId { get; set; }

        public virtual Contact Contact { get; set; }

        public virtual Entity Entity { get; set; }
    }
}
