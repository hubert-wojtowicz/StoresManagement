using StoresManagement.Models;
using System.Data.Entity.ModelConfiguration;

namespace StoresManagement.Migrations.EntityConfigurations
{
    public class BranchConfiguration : EntityTypeConfiguration<Branch>
    {
        public BranchConfiguration()
        {
            Property(x => x.Name)
                .HasMaxLength(50);

            HasRequired(b => b.Entity)
            .WithMany(e => e.Branches)
            .HasForeignKey(b => b.EntityId)
            .WillCascadeOnDelete(false);

            HasRequired(t => t.Contact)
            .WithOptional(t => t.Branch);
        }
    }
}