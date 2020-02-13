using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StoresManagement.Models
{
    public class Entity
    {
        public Entity()
        {
            Branches = new HashSet<Branch>();
            Customers = new HashSet<Customer>();
        }

        [Display(Name = "Entity - Entity Id")]
        public int Id { get; set; }

        [Display(Name = "Entity - Entity Name")]
        public string EntityName { get; set; }

        public virtual ICollection<Branch> Branches { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}