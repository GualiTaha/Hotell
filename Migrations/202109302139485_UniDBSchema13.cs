namespace HotelGestion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UniDBSchema13 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Paiements", "chambre_Id", "dbo.Chambres");
            DropIndex("dbo.Paiements", new[] { "chambre_Id" });
            DropTable("dbo.Paiements");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Paiements",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        numerocarte = c.String(),
                        DateExpiration = c.DateTime(nullable: false),
                        cvv = c.Int(nullable: false),
                        chambre_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Paiements", "chambre_Id");
            AddForeignKey("dbo.Paiements", "chambre_Id", "dbo.Chambres", "Id");
        }
    }
}
