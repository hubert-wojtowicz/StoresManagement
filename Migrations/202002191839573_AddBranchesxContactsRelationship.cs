namespace StoresManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBranchesxContactsRelationship : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Branches", "ContactId", c => c.Int(nullable: false));
            AlterColumn("dbo.Contacts", "EntityId", c => c.Int(nullable: false));
            CreateIndex("dbo.Branches", "ContactId");
            AddForeignKey("dbo.Branches", "ContactId", "dbo.Contacts", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Branches", "ContactId", "dbo.Contacts");
            DropIndex("dbo.Branches", new[] { "ContactId" });
            AlterColumn("dbo.Contacts", "EntityId", c => c.Int());
            DropColumn("dbo.Branches", "ContactId");
        }
    }
}
