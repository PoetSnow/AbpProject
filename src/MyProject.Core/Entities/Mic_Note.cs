using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.Entities
{
    /// <summary>
    /// mic_Note:实体类(登录日志表)
    /// </summary>
    [Serializable]
    public  class Mic_Note : Entity
    {

        #region Model
        /// <summary>
        /// 主键id (登录日志表 )
        /// </summary>

        [Column("id")]
        public override int Id { get; set; }

        /// <summary>
        /// 登录用户名
        /// </summary>
        public string username
        {
            set;
            get;
        }
        /// <summary>
        /// 登录时间
        /// </summary>
        public DateTime date_time
        {
            set;
            get;
        }
        /// <summary>
        /// 登录IP地址
        /// </summary>
        public string user_ip
        {
            set;
            get;
        }
        /// <summary>
        /// 状态 1-登录成功
        /// </summary>
        public int Success
        {
            set;
            get;
        }
        #endregion Model

    }
}

