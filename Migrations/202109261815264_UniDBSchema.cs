namespace HotelGestion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UniDBSchema : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Chambres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Numero = c.String(),
                        ChambreType = c.Int(nullable: false),
                        Options = c.String(),
                        Etat = c.Boolean(nullable: false),
                        Prix = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Path = c.String(),
                        Chambre_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Chambres", t => t.Chambre_Id)
                .Index(t => t.Chambre_Id);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        Prenom = c.String(),
                        Tel = c.String(),
                        Compte_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Comptes", t => t.Compte_Id)
                .Index(t => t.Compte_Id);
            
            CreateTable(
                "dbo.Comptes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        email = c.String(),
                        Passwd = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateDebut = c.DateTime(nullable: false),
                        NbrJour = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        Chambre_Id = c.Int(),
                        Facture_Id = c.Int(),
                        Client_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Chambres", t => t.Chambre_Id)
                .ForeignKey("dbo.Factures", t => t.Facture_Id)
                .ForeignKey("dbo.Clients", t => t.Client_Id)
                .Index(t => t.Chambre_Id)
                .Index(t => t.Facture_Id)
                .Index(t => t.Client_Id);
            
            CreateTable(
                "dbo.Factures",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Prix = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservations", "Client_Id", "dbo.Clients");
            DropForeignKey("dbo.Reservations", "Facture_Id", "dbo.Factures");
            DropForeignKey("dbo.Reservations", "Chambre_Id", "dbo.Chambres");
            DropForeignKey("dbo.Clients", "Compte_Id", "dbo.Comptes");
            DropForeignKey("dbo.Images", "Chambre_Id", "dbo.Chambres");
            DropIndex("dbo.Reservations", new[] { "Client_Id" });
            DropIndex("dbo.Reservations", new[] { "Facture_Id" });
            DropIndex("dbo.Reservations", new[] { "Chambre_Id" });
            DropIndex("dbo.Clients", new[] { "Compte_Id" });
            DropIndex("dbo.Images", new[] { "Chambre_Id" });
            DropTable("dbo.Factures");
            DropTable("dbo.Reservations");
            DropTable("dbo.Comptes");
            DropTable("dbo.Clients");
            DropTable("dbo.Images");
            DropTable("dbo.Chambres");
        }
    }
}
