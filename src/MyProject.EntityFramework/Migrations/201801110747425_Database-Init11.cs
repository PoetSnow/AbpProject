namespace MyProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DatabaseInit11 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Mic_Type",
                c => new
                    {
                        type_id = c.Int(nullable: false, identity: true),
                        type_name = c.String(),
                        parent_id = c.Int(),
                        order_id = c.Int(nullable: false),
                        n_id = c.Int(),
                        url = c.String(),
                        description = c.String(),
                        previewURL = c.String(),
                        target = c.Int(nullable: false),
                        display = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.type_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Mic_Type");
        }
    }
}
