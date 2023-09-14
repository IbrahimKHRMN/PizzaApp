namespace PizzaApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Malzemes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MalzemeAdi = c.String(nullable: false),
                        MalzemeninFiyati = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Malzemes");
        }
    }
}
