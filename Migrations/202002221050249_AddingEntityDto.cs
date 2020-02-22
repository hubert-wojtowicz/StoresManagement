namespace StoresManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingEntityDto : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Entities", "Name", c => c.String());
            DropColumn("dbo.Entities", "EntityName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Entities", "EntityName", c => c.String());
            DropColumn("dbo.Entities", "Name");
        }
    }
}
