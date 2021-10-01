namespace HotelGestion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UniDBSchema15 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reservations", "DateFin", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reservations", "DateFin");
        }
    }
}
