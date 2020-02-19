using StoresManagement.Models;
using System.Data.Entity.ModelConfiguration;

namespace StoresManagement.Migrations.EntityConfigurations
{
    public class PurchaseConfiguration : EntityTypeConfiguration<Purchase>
    {
        public PurchaseConfiguration()
        {
            //HasRequired(c => c.Branch)
            //.WithMany(b => b.Purchases)
            //.HasForeignKey(c => c.BranchId)
            //.WillCascadeOnDelete(false);

            //HasRequired(c => c.Customer)
            //.WithMany(b => b.Purchases)
            //.HasForeignKey(c => c.CustomerId)
            //.WillCascadeOnDelete(false);
        }
    }
}