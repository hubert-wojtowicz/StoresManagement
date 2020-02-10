using System;
using System.ComponentModel.DataAnnotations;

namespace StoresManagement.Models
{
    public class PurchaseItem
    {
        public int EntityId { get; set; }

        [Display(Name = "Purchase Id")]
        public int PurchaseId { get; set; }

        public virtual Purchase Purchase { get; set; }

        [Display(Name = "Product Id")]
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }

        public int Id { get; set; }

        public int? ProductQuantity { get; set; }

        public Decimal? ProductCurrentPrice { get; set; }

        public Decimal? Total { get; set; }

        public Decimal? DiscountTotal { get; set; }
    }
}