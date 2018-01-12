using System.Data.Common;
using Abp.Zero.EntityFramework;
using MyProject.Authorization.Roles;
using MyProject.Authorization.Users;
using MyProject.MultiTenancy;
using System.Data.Entity;
using MyProject.Entities;
using MyProject.Migrations.SeedData;

namespace MyProject.EntityFramework
{
    public class MyProjectDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...
        /// <summary>
        /// 用户
        /// </summary>
        public virtual IDbSet<Mic_Admin> Mic_Admin { get; set; }

        public virtual IDbSet<Fall> Fall { get; set; }

        public virtual IDbSet<Mic_Area> mic_Area { get; set; }

        public virtual IDbSet<Mic_Books> mic_Books { get; set; }
        public virtual IDbSet<Mic_ColumnOperation> mic_ColumnOperation { get; set; }

        public virtual IDbSet<Mic_Company> mic_Company { get; set; }
        public virtual IDbSet<Mic_FEditStyle> mic_FEditStyle { get; set; }
        public virtual IDbSet<Mic_FormType> mic_FormType { get; set; }


        public virtual IDbSet<Mic_GetJob> mic_GetJob { get; set; }
        public virtual IDbSet<Mic_Hotspot> mic_Hotspot { get; set; }
        public virtual IDbSet<Mic_Job> mic_Job { get; set; }

        public virtual IDbSet<Mic_JobType> mic_JobType { get; set; }

        public virtual IDbSet<Mic_Jurisdiction> mic_Jurisdiction { get; set; }
        public virtual IDbSet<Mic_Mimages> mic_Mimages { get; set; }
        public virtual IDbSet<Mic_National> mic_National { get; set; }

        public virtual IDbSet<Mic_Note> mic_Note { get; set; }
        public virtual IDbSet<Mic_Operation> mic_Operation { get; set; }
        public virtual IDbSet<Mic_Projects> mic_Projects { get; set; }

        public virtual IDbSet<Mic_Role> mic_Role { get; set; }
        public virtual IDbSet<Mic_SEO> mic_SEO { get; set; }
        public virtual IDbSet<Mic_SEOStatus> mic_SEOStatus { get; set; }
        public virtual IDbSet<Mic_ThumbnailSettings> mic_ThumbnailSettings { get; set; }
        public virtual IDbSet<Mic_Type> mic_Type { get; set; }
        public virtual IDbSet<Mic_UR> mic_Mic_UR { get; set; }
        public virtual IDbSet<Mic_Video> mic_Mic_Video { get; set; }
        public virtual IDbSet<Mic_Xun> mic_Mic_Xun { get; set; }

      //  public MyProjectDbContext _content;

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public MyProjectDbContext()
            : base("Default")
        {
            //_content = content;
           // new Mic_AdminCreator().Create();
        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in MyProjectDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of MyProjectDbContext since ABP automatically handles it.
         */
        public MyProjectDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
           
        }

        //This constructor is used in tests
        public MyProjectDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public MyProjectDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
