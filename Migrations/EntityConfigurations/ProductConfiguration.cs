using StoresManagement.Models;
using System.Data.Entity.ModelConfiguration;

namespace StoresManagement.Migrations.EntityConfigurations
{
    public class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            HasRequired(c => c.Branch)
            .WithMany(b => b.Products)
            .HasForeignKey(c => c.BranchId)
            .WillCascadeOnDelete(false);
        }
    }
}