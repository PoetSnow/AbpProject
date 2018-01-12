using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Entities
{
    /// <summary>
    /// 用户实体
    /// </summary>
    public class Mic_Admin: Entity
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public override int Id { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public virtual  string UserName { get; set; }

        /// <summary>
        /// 密码(加密)
        /// </summary>
        public virtual string PassWord { get; set; }

        /// <summary>
        /// 密码（未加密）
        /// </summary>
        public virtual string PwdStr { get; set; }

        /// <summary>
        /// 是否锁定
        /// </summary>
        public virtual int Islock { get; set; }

        /// <summary>
        /// 注册时间
        /// </summary>
        public virtual DateTime? Date_Time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual int Num { get; set; }

        /// <summary>
        /// 登录时间
        /// </summary>
        public virtual DateTime? LoginDateTime { get; set; }

        /// <summary>
        /// 登录IP
        /// </summary>
        public virtual string Ip { get; set; }



        public Mic_Admin() { }
        public Mic_Admin(string userName, string passWord, DateTime now)
        {
            UserName = userName;
            PassWord = passWord;
            Date_Time = now;
        }

    }
}
