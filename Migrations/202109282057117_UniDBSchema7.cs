namespace HotelGestion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UniDBSchema7 : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Images");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Path = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
