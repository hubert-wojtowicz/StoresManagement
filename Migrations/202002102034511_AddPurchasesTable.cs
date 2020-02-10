namespace StoresManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPurchasesTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "BranchId", "dbo.Branches");
            CreateTable(
                "dbo.Purchases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EntityId = c.Int(nullable: false),
                        BranchId = c.Int(nullable: false),
                        CustomerId = c.Int(nullable: false),
                        Discount = c.Decimal(precision: 18, scale: 2),
                        Total = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Branches", t => t.BranchId)
                .ForeignKey("dbo.Customers", t => t.CustomerId)
                .Index(t => t.BranchId)
                .Index(t => t.CustomerId);
            
            AlterColumn("dbo.Products", "Price", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.Products", "ExpiryDate", c => c.DateTime());
            AlterColumn("dbo.Products", "Weight", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.Products", "Width", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.Products", "Height", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.Products", "QuantityInStock", c => c.Int());
            AddForeignKey("dbo.Products", "BranchId", "dbo.Branches", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "BranchId", "dbo.Branches");
            DropForeignKey("dbo.Purchases", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Purchases", "BranchId", "dbo.Branches");
            DropIndex("dbo.Purchases", new[] { "CustomerId" });
            DropIndex("dbo.Purchases", new[] { "BranchId" });
            AlterColumn("dbo.Products", "QuantityInStock", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "Height", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Products", "Width", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Products", "Weight", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Products", "ExpiryDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Products", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropTable("dbo.Purchases");
            AddForeignKey("dbo.Products", "BranchId", "dbo.Branches", "Id", cascadeDelete: true);
        }
    }
}
