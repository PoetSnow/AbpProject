using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.Entities
{
    /// <summary>
    /// mic_Company:实体类(公司管理表)
    /// </summary>
    [Table("Mic_Company")]
    public  class Mic_Company : Entity
    {

        #region Model
    
        /// <summary>
        /// 主键ID (公司管理表)
        /// </summary>
        [Column("companey_id")]
        public override int Id { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string companey_name { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string companey_address { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int companey_order { get; set; }

        /// <summary>
        /// 图片
        /// </summary>
        public string companey_image { get; set; }

        /// <summary>
        /// 公司描述
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime companey_datetime { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        public string companey_telepho { get; set; }

        /// <summary>
        /// 邮编
        /// </summary>
        public string companey_youbian { get; set; }

        /// <summary>
        /// 传真
        /// </summary>
        public string companey_chuanzhen { get; set; }

        /// <summary>
        /// E-mail
        /// </summary>
        public string companey_email { get; set; }
  
        #endregion Model

    }
}

