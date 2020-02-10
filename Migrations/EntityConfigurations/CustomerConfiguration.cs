using StoresManagement.Models;
using System.Data.Entity.ModelConfiguration;

namespace StoresManagement.Migrations.EntityConfigurations
{
    public class CustomerConfiguration : EntityTypeConfiguration<Customer>
    {
        public CustomerConfiguration()
        {
            HasRequired(b => b.Entity)
            .WithMany(e => e.Customers)
            .HasForeignKey(b => b.EntityId)
            .WillCascadeOnDelete(false);

            HasRequired(t => t.Contact)
            .WithOptional(t => t.Customer);
        }
    }
}