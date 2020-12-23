namespace FlowerShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _7 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProductFlower", "FlowerId", "dbo.Flower");
            DropForeignKey("dbo.ProductPackaging", "Packaging_Id", "dbo.Packaging");
            DropIndex("dbo.ProductFlower", new[] { "FlowerId" });
            DropIndex("dbo.ProductPackaging", new[] { "Packaging_Id" });
            AddColumn("dbo.ProductPackaging", "PackagingId", c => c.Int(nullable: false));
            DropColumn("dbo.ProductPackaging", "Packaging_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProductPackaging", "Packaging_Id", c => c.Int(nullable: false));
            DropColumn("dbo.ProductPackaging", "PackagingId");
            CreateIndex("dbo.ProductPackaging", "Packaging_Id");
            CreateIndex("dbo.ProductFlower", "FlowerId");
            AddForeignKey("dbo.ProductPackaging", "Packaging_Id", "dbo.Packaging", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ProductFlower", "FlowerId", "dbo.Flower", "Id", cascadeDelete: true);
        }
    }
}
