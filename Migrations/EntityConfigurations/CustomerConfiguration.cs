using StoresManagement.Models;
using System.Data.Entity.ModelConfiguration;

namespace StoresManagement.Migrations.EntityConfigurations
{
    public class CustomerConfiguration : EntityTypeConfiguration<Customer>
    {
        public CustomerConfiguration()
        {
            // Entity 1 x N Customers
            HasRequired(c => c.Entity)
            .WithMany(e => e.Customers)
            .HasForeignKey(c => c.EntityId)
            .WillCascadeOnDelete(false);

            //// Contact 1 x 1 Customer (Optional)
            //HasOptional<Contact>(c => c.Contact)
            //.WithOptionalPrincipal(co => co.Customer)
            //.Map(c => c.MapKey("ContactId"))
            //.WillCascadeOnDelete(false);
        }
    }
}