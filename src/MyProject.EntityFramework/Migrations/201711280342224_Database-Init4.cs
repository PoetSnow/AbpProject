namespace MyProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DatabaseInit4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Mic_Admin",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        PassWord = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Mic_Admin");
        }
    }
}
