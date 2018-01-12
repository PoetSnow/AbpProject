namespace MyProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DatabaseInit5 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fall",
                c => new
                    {
                        Ftid = c.Int(nullable: false, identity: true),
                        Ftitle1 = c.String(),
                        Ftitle2 = c.String(),
                        Ftitle3 = c.String(),
                        Ftitle4 = c.String(),
                        Ftitle5 = c.String(),
                        Ftitle6 = c.String(),
                        Ftitle7 = c.String(),
                        Ftitle8 = c.String(),
                        Ftitle9 = c.String(),
                        Ftitle10 = c.String(),
                        Ftitle11 = c.String(),
                        Ftitle12 = c.String(),
                        Ftitle13 = c.String(),
                        Ftitle14 = c.String(),
                        Ftitle15 = c.String(),
                        Ftitle16 = c.String(),
                        Ftitle17 = c.String(),
                        Ftitle18 = c.String(),
                        Ftitle19 = c.String(),
                        Ftitle20 = c.String(),
                        Ftitle21 = c.String(),
                        Ftitle22 = c.String(),
                        Ftitle23 = c.String(),
                        Ftitle24 = c.String(),
                        Ftitle25 = c.String(),
                        Ftitle26 = c.String(),
                        Ftitle27 = c.String(),
                        Ftitle28 = c.String(),
                        Ftitle29 = c.String(),
                        Ftitle30 = c.String(),
                        Fid = c.Int(nullable: false),
                        Fspic = c.String(maxLength: 50),
                        Fbpic = c.String(maxLength: 50),
                        Fcontent = c.String(),
                        Fname = c.String(maxLength: 50),
                        Fdatetime = c.DateTime(nullable: false),
                        Fistop = c.Boolean(nullable: false),
                        Companeyid = c.Int(nullable: false),
                        Companeyname = c.String(maxLength: 50),
                        FViewNum = c.Int(nullable: false),
                        FisShow = c.Boolean(nullable: false),
                        FisDel = c.Boolean(nullable: false),
                        FisSort = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Ftid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Fall");
        }
    }
}
