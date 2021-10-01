namespace HotelGestion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UniDBSchema1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Chambres", "Prix", c => c.Double(nullable: false));
            AlterColumn("dbo.Reservations", "Price", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Reservations", "Price", c => c.Int(nullable: false));
            AlterColumn("dbo.Chambres", "Prix", c => c.Int(nullable: false));
        }
    }
}
