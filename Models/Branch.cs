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
            //Products = new HashSet<Product>();
            //Purchases = new HashSet<Purchase>();
        }

        public int EntityId { get; set; }

        public virtual Entity Entity { get; set; }

        public int Id { get; set; }

        [Display(Name = "Branch Identification")]
        public string Identification { get; set; }

        [Display(Name = "Branch Type")]
        public char? Type { get; set; }

        [Display(Name = "Branch Name")]
        public string Name { get; set; }

        [Display(Name = "Contact Object")]
        public virtual Contact Contact { get; set; }

        //public virtual ICollection<Product> Products { get; set; }

        //public virtual ICollection<Purchase> Purchases { get; set; }
    }
}