namespace FlowerShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bouquet",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        PackagingId = c.Int(nullable: false),
                        Message = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProductPackaging", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.ProductFlower",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.Int(nullable: false),
                        FlowerId = c.Int(nullable: false),
                        Bouquet_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Flower", t => t.FlowerId, cascadeDelete: true)
                .ForeignKey("dbo.Bouquet", t => t.Bouquet_Id, cascadeDelete: true)
                .Index(t => t.FlowerId)
                .Index(t => t.Bouquet_Id);
            
            CreateTable(
                "dbo.Flower",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Color = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductPackaging",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Packaging_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Packaging", t => t.Packaging_Id, cascadeDelete: true)
                .Index(t => t.Packaging_Id);
            
            CreateTable(
                "dbo.Packaging",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Color = c.String(),
                        Material = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Order",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DeliveryDate = c.DateTime(nullable: false),
                        Client_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Client", t => t.Client_Id)
                .Index(t => t.Client_Id);
            
            CreateTable(
                "dbo.BouquetInOrder",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BouquetId = c.Int(nullable: false),
                        Number = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OrderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Order", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.OrderId);
            
            CreateTable(
                "dbo.Client",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        DeliveryAddress = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FlowerInOrder",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FlowerId = c.Int(nullable: false),
                        Number = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OrderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Order", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.OrderId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FlowerInOrder", "OrderId", "dbo.Order");
            DropForeignKey("dbo.Order", "Client_Id", "dbo.Client");
            DropForeignKey("dbo.BouquetInOrder", "OrderId", "dbo.Order");
            DropForeignKey("dbo.Bouquet", "Id", "dbo.ProductPackaging");
            DropForeignKey("dbo.ProductPackaging", "Packaging_Id", "dbo.Packaging");
            DropForeignKey("dbo.ProductFlower", "Bouquet_Id", "dbo.Bouquet");
            DropForeignKey("dbo.ProductFlower", "FlowerId", "dbo.Flower");
            DropIndex("dbo.FlowerInOrder", new[] { "OrderId" });
            DropIndex("dbo.BouquetInOrder", new[] { "OrderId" });
            DropIndex("dbo.Order", new[] { "Client_Id" });
            DropIndex("dbo.ProductPackaging", new[] { "Packaging_Id" });
            DropIndex("dbo.ProductFlower", new[] { "Bouquet_Id" });
            DropIndex("dbo.ProductFlower", new[] { "FlowerId" });
            DropIndex("dbo.Bouquet", new[] { "Id" });
            DropTable("dbo.FlowerInOrder");
            DropTable("dbo.Client");
            DropTable("dbo.BouquetInOrder");
            DropTable("dbo.Order");
            DropTable("dbo.Packaging");
            DropTable("dbo.ProductPackaging");
            DropTable("dbo.Flower");
            DropTable("dbo.ProductFlower");
            DropTable("dbo.Bouquet");
        }
    }
}
