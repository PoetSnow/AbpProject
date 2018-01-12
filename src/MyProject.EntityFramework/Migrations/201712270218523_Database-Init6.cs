namespace MyProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DatabaseInit6 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Mic_Area",
                c => new
                    {
                        AreaID = c.Int(nullable: false, identity: true),
                        AreaCode = c.Int(nullable: false),
                        AreaName = c.String(),
                        AreaParentID = c.Int(nullable: false),
                        AreaParentCode = c.String(),
                        AreaLevelID = c.Int(nullable: false),
                        AreaOrderID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AreaID);
            
            CreateTable(
                "dbo.Mic_Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Company_Name = c.String(),
                        Contact = c.String(),
                        E_mail = c.String(),
                        Tel = c.String(),
                        Company_Address = c.String(),
                        Content = c.String(),
                        HuiFu = c.String(),
                        type = c.Int(nullable: false),
                        typename = c.String(),
                        Status = c.Boolean(nullable: false),
                        date_time = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Mic_ColumnOperation",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        role_Id = c.Int(nullable: false),
                        type_Id = c.Int(nullable: false),
                        C_add = c.Boolean(nullable: false),
                        C_update = c.Boolean(nullable: false),
                        C_delete = c.Boolean(nullable: false),
                        C_datatype = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Mic_Company",
                c => new
                    {
                        companey_id = c.Int(nullable: false, identity: true),
                        companey_name = c.String(),
                        companey_address = c.String(),
                        companey_order = c.Int(nullable: false),
                        companey_image = c.String(),
                        description = c.String(),
                        companey_datetime = c.DateTime(nullable: false),
                        companey_telepho = c.String(),
                        companey_youbian = c.String(),
                        companey_chuanzhen = c.String(),
                        companey_email = c.String(),
                    })
                .PrimaryKey(t => t.companey_id);
            
            CreateTable(
                "dbo.Mic_FEditStyle",
                c => new
                    {
                        FEid = c.Int(nullable: false, identity: true),
                        FEfield = c.String(),
                        FEfieldid = c.Int(),
                        FEmean = c.String(),
                        FEwidth = c.String(),
                        FEwidthPercent = c.Boolean(nullable: false),
                        FEheigth = c.String(),
                        FErow = c.Int(nullable: false),
                        FEmust = c.Boolean(nullable: false),
                        FEpos = c.String(),
                        FEex = c.String(),
                        Fid = c.Int(nullable: false),
                        FESourcesFid = c.String(),
                        FESourcesItems = c.String(),
                        FEtu = c.Boolean(),
                        FEbj = c.Boolean(),
                        FEOrderID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FEid);
            
            CreateTable(
                "dbo.Mic_FormType",
                c => new
                    {
                        Id1 = c.Int(nullable: false, identity: true),
                        Ftype = c.String(),
                        Ftypeid = c.Int(),
                        Fname = c.String(),
                        Fintro = c.String(),
                        Fistu1 = c.Boolean(nullable: false),
                        Fistu2 = c.Boolean(nullable: false),
                        Fistu3 = c.Boolean(nullable: false),
                        F_pt = c.Boolean(nullable: false),
                        F_xmdt = c.Boolean(nullable: false),
                        F_ysgg = c.Boolean(nullable: false),
                        Fiscontent = c.Boolean(nullable: false),
                        Fdatatype = c.Boolean(nullable: false),
                        FEtudes1 = c.String(),
                        FEtudes2 = c.String(),
                        FEtudes3 = c.String(),
                        FSpictures = c.String(),
                        FBpictures = c.String(),
                        Fcom = c.Boolean(nullable: false),
                        Fdate = c.Boolean(nullable: false),
                        Fadd = c.Boolean(nullable: false),
                        Fupdate = c.Boolean(nullable: false),
                        Fdelete = c.Boolean(nullable: false),
                        Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id1);
            
            CreateTable(
                "dbo.Mic_GetJob",
                c => new
                    {
                        WorkperID = c.Int(nullable: false, identity: true),
                        TureName = c.String(),
                        Sex = c.String(),
                        PersenCard = c.String(),
                        Birthday = c.String(),
                        BirthAddress = c.String(),
                        Nation = c.String(),
                        Address = c.String(),
                        Marry = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        School = c.String(),
                        LeaveTime = c.String(),
                        ZhuanYe = c.String(),
                        XueLi = c.String(),
                        Computer = c.String(),
                        ComputerLevel = c.String(),
                        Languages = c.String(),
                        LanguageLevel = c.String(),
                        WorkName = c.String(),
                        WorkID = c.Int(nullable: false),
                        Money = c.String(),
                        Description = c.String(),
                        SchoolDetail = c.String(),
                        WorkDetail = c.String(),
                        Remark = c.String(),
                        WorkTypeID = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        DateAndTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.WorkperID);
            
            CreateTable(
                "dbo.Mic_Hotspot",
                c => new
                    {
                        HID = c.Int(nullable: false, identity: true),
                        Ftid = c.Int(nullable: false),
                        HTitle = c.String(),
                        HURL = c.String(),
                        HPic = c.String(),
                        HBeginX = c.Decimal(nullable: false, precision: 18, scale: 2),
                        HBeginY = c.Decimal(nullable: false, precision: 18, scale: 2),
                        HEndX = c.Decimal(nullable: false, precision: 18, scale: 2),
                        HEndY = c.Decimal(nullable: false, precision: 18, scale: 2),
                        HWidth = c.Decimal(nullable: false, precision: 18, scale: 2),
                        HHeight = c.Decimal(nullable: false, precision: 18, scale: 2),
                        HContent = c.String(),
                        HStatus = c.Int(nullable: false),
                        HRemark = c.String(),
                        HDatetime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.HID);
            
            CreateTable(
                "dbo.Mic_Job",
                c => new
                    {
                        job_id = c.Int(nullable: false, identity: true),
                        job_name = c.String(),
                        job_type = c.String(),
                        job_pernuber = c.Int(nullable: false),
                        job_bumen = c.String(),
                        job_companey = c.String(),
                        job_companey_id = c.Int(),
                        job_istop = c.Boolean(nullable: false),
                        job_isshow = c.Boolean(nullable: false),
                        date_time = c.DateTime(nullable: false),
                        job_adress = c.String(),
                        job_condition = c.String(),
                        job_sex = c.String(),
                        job_xueli = c.String(),
                        job_zhuanye = c.String(),
                        job_money = c.String(),
                        guoqi = c.DateTime(),
                        zhize = c.String(),
                        ZhiWeiTypeID = c.Int(nullable: false),
                        ZhiWeiTypeName = c.String(),
                    })
                .PrimaryKey(t => t.job_id);
            
            CreateTable(
                "dbo.Mic_JobType",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TypeName = c.String(),
                        JoinDatetime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Mic_Jurisdiction",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        type_mode = c.String(),
                        role_id = c.Int(nullable: false),
                        descirption = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Mic_Mimages",
                c => new
                    {
                        img_id = c.Int(nullable: false, identity: true),
                        FTid = c.Int(nullable: false),
                        Title = c.String(),
                        EnTitle = c.String(),
                        min_img = c.String(),
                        max_img = c.String(),
                        is_top = c.Boolean(nullable: false),
                        Description = c.String(),
                        TypeID = c.Int(nullable: false),
                        TypeName = c.String(),
                        date_time = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.img_id);
            
            CreateTable(
                "dbo.Mic_National",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        CNName = c.String(),
                        ENName = c.String(),
                        OrderID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Mic_National");
            DropTable("dbo.Mic_Mimages");
            DropTable("dbo.Mic_Jurisdiction");
            DropTable("dbo.Mic_JobType");
            DropTable("dbo.Mic_Job");
            DropTable("dbo.Mic_Hotspot");
            DropTable("dbo.Mic_GetJob");
            DropTable("dbo.Mic_FormType");
            DropTable("dbo.Mic_FEditStyle");
            DropTable("dbo.Mic_Company");
            DropTable("dbo.Mic_ColumnOperation");
            DropTable("dbo.Mic_Books");
            DropTable("dbo.Mic_Area");
        }
    }
}
