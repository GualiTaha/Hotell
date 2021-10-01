namespace HotelGestion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UniDBSchema3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Chambres", "Image", c => c.Binary());
            DropColumn("dbo.Chambres", "ImageChambre");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Chambres", "ImageChambre", c => c.String());
            DropColumn("dbo.Chambres", "Image");
        }
    }
}
