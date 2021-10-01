namespace HotelGestion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UniDBSchema2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Images", "Chambre_Id", "dbo.Chambres");
            DropIndex("dbo.Images", new[] { "Chambre_Id" });
            AddColumn("dbo.Chambres", "ImageChambre", c => c.String());
            DropColumn("dbo.Images", "Chambre_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Images", "Chambre_Id", c => c.Int());
            DropColumn("dbo.Chambres", "ImageChambre");
            CreateIndex("dbo.Images", "Chambre_Id");
            AddForeignKey("dbo.Images", "Chambre_Id", "dbo.Chambres", "Id");
        }
    }
}
