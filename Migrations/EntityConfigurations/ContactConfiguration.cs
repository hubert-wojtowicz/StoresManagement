using StoresManagement.Models;
using System.Data.Entity.ModelConfiguration;

namespace StoresManagement.Migrations.EntityConfigurations
{
    public class ContactConfiguration : EntityTypeConfiguration<Contact>
    {
        public ContactConfiguration()
        {
            //HasKey(t => t.Id);
        }
    }
}