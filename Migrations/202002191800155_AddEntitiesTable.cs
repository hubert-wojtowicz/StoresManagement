namespace StoresManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEntitiesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Entities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EntityName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Entities");
        }
    }
}
