namespace FlowerShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _5 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PackagingPrice",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PackagingId = c.Int(nullable: false),
                        PricePackaging = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Number = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Packaging" , t=> t.PackagingId)
                .Index(t=> t.PackagingId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PackagingPrice");
        }
    }
}
