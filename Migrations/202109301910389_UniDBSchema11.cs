namespace HotelGestion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UniDBSchema11 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Paiements", "reservation_Id", c => c.Int());
            CreateIndex("dbo.Paiements", "reservation_Id");
            AddForeignKey("dbo.Paiements", "reservation_Id", "dbo.Reservations", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Paiements", "reservation_Id", "dbo.Reservations");
            DropIndex("dbo.Paiements", new[] { "reservation_Id" });
            DropColumn("dbo.Paiements", "reservation_Id");
        }
    }
}
