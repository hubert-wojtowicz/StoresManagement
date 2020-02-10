using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StoresManagement.Models
{
    public class Purchase
    {
        public int EntityId { get; set; }

        [Display(Name = "Branch Id")]
        public int BranchId { get; set; }

        public virtual Branch Branch { get; set; }

        [Display(Name = "Customer Id")]
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }

        public int Id { get; set; }

        public Decimal? Discount { get; set; }

        public Decimal? Total { get; set; }

        public ICollection<PurchaseItem> PurchaseItems { get; set; }
    }
}