namespace FlowerShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _10 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bouquet", "DateTimeOfCreateBouquet", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Bouquet", "DateTimeOfCreateBouquet");
        }
    }
}
