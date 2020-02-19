namespace StoresManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBranchesxContactsRelationship : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Branches", "ContactId", c => c.Int(nullable: false));
            AddColumn("dbo.Contacts", "Branch_Id", c => c.Int());
            CreateIndex("dbo.Branches", "ContactId");
            CreateIndex("dbo.Contacts", "Branch_Id");
            AddForeignKey("dbo.Contacts", "Branch_Id", "dbo.Branches", "Id");
            AddForeignKey("dbo.Branches", "ContactId", "dbo.Contacts", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Branches", "ContactId", "dbo.Contacts");
            DropForeignKey("dbo.Contacts", "Branch_Id", "dbo.Branches");
            DropIndex("dbo.Contacts", new[] { "Branch_Id" });
            DropIndex("dbo.Branches", new[] { "ContactId" });
            DropColumn("dbo.Contacts", "Branch_Id");
            DropColumn("dbo.Branches", "ContactId");
        }
    }
}
