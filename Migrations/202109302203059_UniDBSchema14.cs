namespace HotelGestion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UniDBSchema14 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Paiements",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        numeroCarte = c.String(),
                        dateValidite = c.DateTime(nullable: false),
                        ccv = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Paiements");
        }
    }
}
