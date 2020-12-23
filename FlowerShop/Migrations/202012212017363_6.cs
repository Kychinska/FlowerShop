namespace FlowerShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _6 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.FlowerInOrder", "OrderId", "dbo.Order");
            DropIndex("dbo.FlowerInOrder", new[] { "OrderId" });
            DropTable("dbo.FlowerInOrder");
        }
        
        public override void Down()
        {
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
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.FlowerInOrder", "OrderId");
            AddForeignKey("dbo.FlowerInOrder", "OrderId", "dbo.Order", "Id", cascadeDelete: true);
        }
    }
}
