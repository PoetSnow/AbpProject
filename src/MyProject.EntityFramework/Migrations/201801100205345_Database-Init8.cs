namespace MyProject.Migrations
{
    using MyProject.Migrations.SeedData;
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DatabaseInit8 : DbMigration
    {
       
        public override void Up()
        {
            AddColumn("dbo.Mic_Admin", "PwdStr", c => c.String());
            AddColumn("dbo.Mic_Admin", "Islock", c => c.Int(nullable: false));
            AddColumn("dbo.Mic_Admin", "Date_Time", c => c.DateTime());
            AddColumn("dbo.Mic_Admin", "Num", c => c.Int(nullable: false));
            AddColumn("dbo.Mic_Admin", "LoginDateTime", c => c.DateTime());
            AddColumn("dbo.Mic_Admin", "Ip", c => c.String());           
        }
        
        public override void Down()
        {
            DropColumn("dbo.Mic_Admin", "Ip");
            DropColumn("dbo.Mic_Admin", "LoginDateTime");
            DropColumn("dbo.Mic_Admin", "Num");
            DropColumn("dbo.Mic_Admin", "Date_Time");
            DropColumn("dbo.Mic_Admin", "Islock");
            DropColumn("dbo.Mic_Admin", "PwdStr");
        }
      
    }
}
