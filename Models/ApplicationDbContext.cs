using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StoresManagement.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Entity> Entities { get; set; }
        public DbSet<Branch> Branches { get; set; }
        //public DbSet<Customer> Customers { get; set; }
        //public DbSet<Contact> Contacts { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Configurations.Add(new EntityConfiguration());
        //    modelBuilder.Configurations.Add(new BranchConfiguration());
        //    modelBuilder.Configurations.Add(new CustomerConfiguration());
        //    modelBuilder.Configurations.Add(new ContactConfiguration());
        //}
    }
}