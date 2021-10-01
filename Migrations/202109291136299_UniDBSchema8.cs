namespace HotelGestion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UniDBSchema8 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Reservations", "Facture_Id", "dbo.Factures");
            DropIndex("dbo.Reservations", new[] { "Facture_Id" });
            DropIndex("dbo.Reservations", new[] { "Client_Id" });
            AlterColumn("dbo.Chambres", "Prix", c => c.Int(nullable: false));
            AlterColumn("dbo.Reservations", "Price", c => c.Int(nullable: false));
            CreateIndex("dbo.Reservations", "client_Id");
            DropColumn("dbo.Reservations", "Facture_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reservations", "Facture_Id", c => c.Int());
            DropIndex("dbo.Reservations", new[] { "client_Id" });
            AlterColumn("dbo.Reservations", "Price", c => c.Double(nullable: false));
            AlterColumn("dbo.Chambres", "Prix", c => c.Double(nullable: false));
            CreateIndex("dbo.Reservations", "Client_Id");
            CreateIndex("dbo.Reservations", "Facture_Id");
            AddForeignKey("dbo.Reservations", "Facture_Id", "dbo.Factures", "Id");
        }
    }
}
