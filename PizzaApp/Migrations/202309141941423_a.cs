namespace PizzaApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pizzalars",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PizzaAdi = c.String(nullable: false),
                        PizzaFiyati = c.Double(nullable: false),
                        Icindekiler = c.String(nullable: false),
                        ImageUrl = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            AlterColumn("dbo.Kullanicilars", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Kullanicilars", "Parola", c => c.String(nullable: false));
            AlterColumn("dbo.Kullanicilars", "Ad", c => c.String(nullable: false));
            AlterColumn("dbo.Kullanicilars", "Soyad", c => c.String(nullable: false));
            AlterColumn("dbo.Kullanicilars", "Cinsiyet", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Kullanicilars", "Cinsiyet", c => c.String());
            AlterColumn("dbo.Kullanicilars", "Soyad", c => c.String());
            AlterColumn("dbo.Kullanicilars", "Ad", c => c.String());
            AlterColumn("dbo.Kullanicilars", "Parola", c => c.String());
            AlterColumn("dbo.Kullanicilars", "Email", c => c.String());
            DropTable("dbo.Pizzalars");
        }
    }
}
