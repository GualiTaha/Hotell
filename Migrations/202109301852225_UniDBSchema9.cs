namespace HotelGestion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UniDBSchema9 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Paiements",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Paiements");
        }
    }
}