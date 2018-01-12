namespace MyProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DatabaseInit7 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Mic_UR",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        username = c.String(),
                        role_name = c.String(),
                        role_id = c.Int(),
                        description = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Mic_Video",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Ftid = c.Int(),
                        Title = c.String(),
                        SImg = c.String(),
                        BImg = c.String(),
                        FilePath = c.String(),
                        OriginalFileName = c.String(),
                        Description = c.String(),
                        IsTop = c.Boolean(nullable: false),
                        JoinDatetime = c.DateTime(nullable: false),
                        TypeId = c.Int(),
                        TypeName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Mic_Xun",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Perent_id = c.Int(),
                        con = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Mic_Note",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        username = c.String(),
                        date_time = c.DateTime(nullable: false),
                        user_ip = c.String(),
                        Success = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Mic_Operation",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ColumnName = c.String(),
                        Status = c.Int(nullable: false),
                        MessageInfo = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Mic_Projects",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        FTid = c.Int(nullable: false),
                        P_title = c.String(),
                        P_img = c.String(),
                        P_content = c.String(),
                        P_istop = c.Boolean(nullable: false),
                        P_datetime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Mic_Role",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        role_name = c.String(),
                        role_description = c.String(),
                        date_time = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Mic_SEO",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PageTitle = c.String(),
                        Keywords = c.String(),
                        Description = c.String(),
                        Remarks = c.String(),
                        IsShow = c.Boolean(nullable: false),
                        JoinDatetime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Mic_SEOStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Mic_ThumbnailSettings",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Fid = c.Int(nullable: false),
                        FEfieldName = c.String(),
                        FolderName = c.String(),
                        Width = c.Int(nullable: false),
                        Height = c.Int(nullable: false),
                        Type = c.Int(nullable: false),
                        Status = c.Boolean(nullable: false),
                        PartType = c.Int(nullable: false),
                        Remarks = c.String(),
                        JoinDatetime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
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
            DropTable("dbo.Mic_ThumbnailSettings");
            DropTable("dbo.Mic_SEOStatus");
            DropTable("dbo.Mic_SEO");
            DropTable("dbo.Mic_Role");
            DropTable("dbo.Mic_Projects");
            DropTable("dbo.Mic_Operation");
            DropTable("dbo.Mic_Note");
            DropTable("dbo.Mic_Xun");
            DropTable("dbo.Mic_Video");
            DropTable("dbo.Mic_UR");
        }
    }
}
