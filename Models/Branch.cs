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
        //[ForeignKey("Entity")]
        [Display(Name = "Entity Id")]
        public int EntityId { get; set; }

        public virtual Entity Entity { get; set; }

        public int Id { get; set; }

        [Display(Name = "Branch Identification")]
        public string Identification { get; set; }

        [Display(Name = "Branch Type")]
        public char? Type { get; set; }

        [Display(Name = "Branch Name")]
        public string Name { get; set; }

        //[ForeignKey("Contact")]
        public int ContactId { get; set; }

        public virtual Contact Contact { get; set; }
    }
}