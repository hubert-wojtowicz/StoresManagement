namespace StoresManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TableRealationships : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Branches");
            AddColumn("dbo.Branches", "ContactId", c => c.Int(nullable: false));
            AlterColumn("dbo.Branches", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Branches", "Id");
            CreateIndex("dbo.Branches", "Id");
            AddForeignKey("dbo.Branches", "Id", "dbo.Contacts", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Branches", "Id", "dbo.Contacts");
            DropIndex("dbo.Branches", new[] { "Id" });
            DropPrimaryKey("dbo.Branches");
            AlterColumn("dbo.Branches", "Id", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.Branches", "ContactId");
            AddPrimaryKey("dbo.Branches", "Id");
        }
    }
}
