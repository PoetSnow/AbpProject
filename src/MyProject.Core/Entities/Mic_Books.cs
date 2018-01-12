using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.Entities
{
    /// <summary>
    /// mic_Books:实体类(留言反馈信息)
    /// </summary>

    [Table("Mic_Books")]
    public  class Mic_Books : Entity
    {


        /// <summary>
        /// 主键ID
        /// </summary>
        [Column("Id")]
        public override int Id { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public virtual string Title { get; set; }

        /// <summary>
        /// 公司名称
        /// </summary>
        public virtual string Company_Name { get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        public virtual string Contact { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public virtual string E_mail { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        public virtual string Tel { get; set; }

        /// <summary>
        /// 公司地址
        /// </summary>
        public virtual string Company_Address { get; set; }

        /// <summary>
        /// 留言内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 回复
        /// </summary>
        public string HuiFu { get; set; }

        /// <summary>
        /// 类型id 1-留言 2-投诉 等
        /// </summary>
        public int type { get; set; }

        /// <summary>
        /// 类型名称
        /// </summary>
        public string typename { get; set; }

        /// <summary>
        /// 审核状态
        /// </summary>
        public bool Status { get; set; }

        /// <summary>
        /// 提交时间
        /// </summary>
        public DateTime date_time { get; set; }



    }
}

