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

            // Entity 1 x N Branches
            HasRequired(b => b.Entity)
            .WithMany(e => e.Branches)
            .HasForeignKey(b => b.EntityId)
            .WillCascadeOnDelete(false);

            HasRequired(t => t.Contact)
            .WithOptional(t => t.Branch);
            // .Map(c => c.MapKey("ContactId"));

            //HasKey(t => t.Id);

            // Contact 1 x 1 Branch (Optional)
            //HasOptional(b => b.Contact)
            //.WithOptionalPrincipal(c => c.Branch)
            //.Map(b => b.MapKey("ContactId"))
            //.WillCascadeOnDelete(false);

            //HasOptional(p => p.Contact)
            //.WithOptionalPrincipal(o => o.Branch)
            //.Map(x => x.MapKey("ContactId"));
        }
    }
}