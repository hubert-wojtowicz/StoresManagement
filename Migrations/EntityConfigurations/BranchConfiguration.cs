using StoresManagement.Models;
using System.Data.Entity.ModelConfiguration;

namespace StoresManagement.Migrations.EntityConfigurations
{
    public class BranchConfiguration : EntityTypeConfiguration<Branch>
    {
        public BranchConfiguration()
        {
            //HasRequired(b => b.Entity)
            //.WithMany(e => e.Branches)
            //.HasForeignKey(b => b.EntityId)
            //.WillCascadeOnDelete(false);

            //HasOptional(b => b.Contact)
            //    .WithRequired(con => con.Branch);

            //HasRequired(t => t.Contact)
            //.WithOptional(t => t.Branch);

            //HasRequired(t => t.Contact)
            //    .WithMany()
            //    .HasForeignKey(t => t.ContactId);
        }
    }
}