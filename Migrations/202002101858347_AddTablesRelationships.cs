namespace StoresManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTablesRelationships : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Branches", "EntityId", "dbo.Entities");
            DropForeignKey("dbo.Customers", "EntityId", "dbo.Entities");
            DropPrimaryKey("dbo.Branches");
            DropPrimaryKey("dbo.Customers");
            AddColumn("dbo.Branches", "ContactId", c => c.Int());
            AddColumn("dbo.Customers", "ContactId", c => c.Int());
            AlterColumn("dbo.Branches", "Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Branches", "Name", c => c.String(maxLength: 50));
            AlterColumn("dbo.Customers", "Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Customers", "Name", c => c.String(maxLength: 50));
            AddPrimaryKey("dbo.Branches", "Id");
            AddPrimaryKey("dbo.Customers", "Id");
            CreateIndex("dbo.Branches", "Id");
            CreateIndex("dbo.Customers", "Id");
            AddForeignKey("dbo.Customers", "Id", "dbo.Contacts", "Id");
            AddForeignKey("dbo.Branches", "Id", "dbo.Contacts", "Id");
            AddForeignKey("dbo.Branches", "EntityId", "dbo.Entities", "Id");
            AddForeignKey("dbo.Customers", "EntityId", "dbo.Entities", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "EntityId", "dbo.Entities");
            DropForeignKey("dbo.Branches", "EntityId", "dbo.Entities");
            DropForeignKey("dbo.Branches", "Id", "dbo.Contacts");
            DropForeignKey("dbo.Customers", "Id", "dbo.Contacts");
            DropIndex("dbo.Customers", new[] { "Id" });
            DropIndex("dbo.Branches", new[] { "Id" });
            DropPrimaryKey("dbo.Customers");
            DropPrimaryKey("dbo.Branches");
            AlterColumn("dbo.Customers", "Name", c => c.String());
            AlterColumn("dbo.Customers", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Branches", "Name", c => c.String());
            AlterColumn("dbo.Branches", "Id", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.Customers", "ContactId");
            DropColumn("dbo.Branches", "ContactId");
            AddPrimaryKey("dbo.Customers", "Id");
            AddPrimaryKey("dbo.Branches", "Id");
            AddForeignKey("dbo.Customers", "EntityId", "dbo.Entities", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Branches", "EntityId", "dbo.Entities", "Id", cascadeDelete: true);
        }
    }
}
