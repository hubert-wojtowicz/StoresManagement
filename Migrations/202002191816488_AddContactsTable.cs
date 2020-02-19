namespace StoresManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddContactsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EntityId = c.Int(),
                        AddressCountry = c.String(),
                        AddressPostalCode = c.String(),
                        AddressState = c.String(),
                        AddressCity = c.String(),
                        AddressStreet = c.String(),
                        AddressNumber = c.Int(),
                        AddressComplement = c.String(),
                        PhoneNumber = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Contacts");
        }
    }
}
