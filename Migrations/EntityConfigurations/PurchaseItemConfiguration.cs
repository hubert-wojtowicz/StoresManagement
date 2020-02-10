using StoresManagement.Models;
using System.Data.Entity.ModelConfiguration;

namespace StoresManagement.Migrations.EntityConfigurations
{
    public class PurchaseItemConfiguration : EntityTypeConfiguration<PurchaseItem>
    {
        public PurchaseItemConfiguration()
        {
            HasRequired(c => c.Purchase)
            .WithMany(b => b.PurchaseItems)
            .HasForeignKey(c => c.PurchaseId)
            .WillCascadeOnDelete(false);

            HasRequired(t => t.Product)
            .WithOptional(t => t.PurchaseItem);
        }
    }
}