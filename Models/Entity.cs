using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StoresManagement.Models
{
    public class Entity
    {
        public int Id { get; set; }

        [Display(Name = "Entity Name")]
        public string EntityName { get; set; }

        public ICollection<Branch> Branches { get; set; }

        //public ICollection<Customer> Customers { get; set; }
    }
}