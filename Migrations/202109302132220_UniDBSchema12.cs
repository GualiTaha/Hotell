namespace HotelGestion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UniDBSchema12 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Paiements", "reservation_Id", "dbo.Reservations");
            DropIndex("dbo.Paiements", new[] { "reservation_Id" });
            AddColumn("dbo.Paiements", "chambre_Id", c => c.Int());
            CreateIndex("dbo.Paiements", "chambre_Id");
            AddForeignKey("dbo.Paiements", "chambre_Id", "dbo.Chambres", "Id");
            DropColumn("dbo.Paiements", "reservation_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Paiements", "reservation_Id", c => c.Int());
            DropForeignKey("dbo.Paiements", "chambre_Id", "dbo.Chambres");
            DropIndex("dbo.Paiements", new[] { "chambre_Id" });
            DropColumn("dbo.Paiements", "chambre_Id");
            CreateIndex("dbo.Paiements", "reservation_Id");
            AddForeignKey("dbo.Paiements", "reservation_Id", "dbo.Reservations", "Id");
        }
    }
}
