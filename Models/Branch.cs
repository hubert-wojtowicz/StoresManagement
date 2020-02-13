using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StoresManagement.Models
{
    public class Branch
    {
        public Branch()
        {
            Products = new HashSet<Product>();
            Purchases = new HashSet<Purchase>();
        }

        //[ForeignKey("Entity")]
        [Display(Name = "Branch - Entity Id")]
        public int EntityId { get; set; }

        [Display(Name = "Branch - Entity Object")]
        public virtual Entity Entity { get; set; }

        [Display(Name = "Branch - Branch Id")]
        public int Id { get; set; }

        [Display(Name = "Branch - Branch Identification")]
        public string Identification { get; set; }

        [Display(Name = "Branch - Branch Type")]
        public char? Type { get; set; }

        [Display(Name = "Branch - Branch Name")]
        public string Name { get; set; }

        [Display(Name = "Branch - Contact Id")]
        public int? ContactId { get; set; }

        [Display(Name = "Branch - Contact Object")]
        public virtual Contact Contact { get; set; }

        public virtual ICollection<Product> Products { get; set; }

        public virtual ICollection<Purchase> Purchases { get; set; }
    }
}