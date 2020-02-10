namespace StoresManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPurchaseItemsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PurchaseItems",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        EntityId = c.Int(nullable: false),
                        PurchaseId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        ProductQuantity = c.Int(),
                        ProductCurrentPrice = c.Decimal(precision: 18, scale: 2),
                        Total = c.Decimal(precision: 18, scale: 2),
                        DiscountTotal = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.Id)
                .ForeignKey("dbo.Purchases", t => t.PurchaseId)
                .Index(t => t.Id)
                .Index(t => t.PurchaseId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PurchaseItems", "PurchaseId", "dbo.Purchases");
            DropForeignKey("dbo.PurchaseItems", "Id", "dbo.Products");
            DropIndex("dbo.PurchaseItems", new[] { "PurchaseId" });
            DropIndex("dbo.PurchaseItems", new[] { "Id" });
            DropTable("dbo.PurchaseItems");
        }
    }
}
