namespace HotelGestion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UniDBSchema5 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Clients", "Compte_Id", "dbo.Comptes");
            DropIndex("dbo.Clients", new[] { "Compte_Id" });
            AddColumn("dbo.Clients", "email", c => c.String());
            AddColumn("dbo.Clients", "Passwd", c => c.String());
            DropColumn("dbo.Clients", "Compte_Id");
            DropTable("dbo.Comptes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Comptes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        email = c.String(),
                        Passwd = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Clients", "Compte_Id", c => c.Int());
            DropColumn("dbo.Clients", "Passwd");
            DropColumn("dbo.Clients", "email");
            CreateIndex("dbo.Clients", "Compte_Id");
            AddForeignKey("dbo.Clients", "Compte_Id", "dbo.Comptes", "Id");
        }
    }
}
