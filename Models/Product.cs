using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StoresManagement.Models
{
    public class Product
    {
        public int EntityId { get; set; }

        [Display(Name = "Entity Id")]
        public int BranchId { get; set; }

        public virtual Branch Branch { get; set; }

        public int Id { get; set; }

        public string Name { get; set; }

        public Decimal? Price { get; set; }

        public DateTime? ExpiryDate { get; set; }

        public Decimal? Weight { get; set; }

        public Decimal? Width { get; set; }

        public Decimal? Height { get; set; }

        public int? QuantityInStock { get; set; }
    }
}