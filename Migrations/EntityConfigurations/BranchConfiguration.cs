using StoresManagement.Models;
using System.Data.Entity.ModelConfiguration;

namespace StoresManagement.Migrations.EntityConfigurations
{
    public class BranchConfiguration : EntityTypeConfiguration<Branch>
    {
        public BranchConfiguration()
        {
            HasRequired(b => b.Entity)
            .WithMany(e => e.Branches)
            .HasForeignKey(b => b.EntityId)
            .WillCascadeOnDelete(false);

            HasRequired(t => t.Contact)
            .WithOptional(t => t.Branch);
        }
    }
}