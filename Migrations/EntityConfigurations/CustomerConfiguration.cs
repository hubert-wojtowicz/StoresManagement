using StoresManagement.Models;
using System.Data.Entity.ModelConfiguration;

namespace StoresManagement.Migrations.EntityConfigurations
{
    public class CustomerConfiguration : EntityTypeConfiguration<Customer>
    {
        public CustomerConfiguration()
        {
            //HasRequired(b => b.Entity)
            //.WithMany(e => e.Customers)
            //.HasForeignKey(b => b.EntityId)
            //.WillCascadeOnDelete(false);

            //HasOptional(c => c.Contact)
            //    .WithRequired(con => con.Customer);

            //HasRequired(t => t.Contact)
            //.WithOptional(t => t.Customer);

            //HasRequired(t => t.Contact)
            //    .WithMany()
            //    .HasForeignKey(t => t.ContactId);
        }
    }
}