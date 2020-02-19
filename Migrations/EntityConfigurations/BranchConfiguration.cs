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

            //HasRequired(b => b.Contact)
            //    .WithOptional(con => con.Branch)
            //    .Map(b => b.MapKey("ContactId");

            //HasRequired(t => t.Contact)
            //.WithOptional(t => t.Branch);

            HasRequired(t => t.Contact)
                .WithMany()
                .HasForeignKey(t => t.ContactId);
        }
    }
}