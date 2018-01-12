using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.Entities
{
    /// <summary>
    /// mic_Job:实体类(招聘信息表)
    /// </summary>
    [Table("Mic_Job")]
    public  class Mic_Job : Entity
    {

        #region Model

        /// <summary>
        /// 主键id (招聘信息表)
        /// </summary>
        [Column("job_id")]
        public override int Id { get; set; }

        /// <summary>
        /// 职位名称
        /// </summary>
        public string job_name { get; set; }

        /// <summary>
        /// 招聘类型 校园招聘或社会招聘
        /// </summary>
        public string job_type { get; set; }

        /// <summary>
        /// 招聘人数 0-表示若干个
        /// </summary>
        public int job_pernuber { get; set; }

        /// <summary>
        /// 所属部门
        /// </summary>
        public string job_bumen { get; set; }

        /// <summary>
        /// 所属公司名称
        /// </summary>
        public string job_companey { get; set; }

        /// <summary>
        /// 所属公司id
        /// </summary>
        public int? job_companey_id { get; set; }

        /// <summary>
        /// 是否置顶显示
        /// </summary>
        public bool job_istop { get; set; }

        /// <summary>
        /// 是否显示 0-不显示 1-显示
        /// </summary>
        public bool job_isshow { get; set; }


        /// <summary>
        /// 发布时间 
        /// </summary>
        public DateTime date_time { get; set; }

        /// <summary>
        /// 工作地点
        /// </summary>
        public string job_adress { get; set; }

        /// <summary>
        /// 职位要求
        /// </summary>
        public string job_condition { get; set; }

        /// <summary>
        /// 性别要求
        /// </summary>
        public string job_sex { get; set; }

        /// <summary>
        /// 学历要求
        /// </summary>
        public string job_xueli { get; set; }

        /// <summary>
        /// 专业要求
        /// </summary>
        public string job_zhuanye { get; set; }

        /// <summary>
        /// 月薪
        /// </summary>
        public string job_money { get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        public DateTime? guoqi { get; set; }

        /// <summary>
        /// 工作职责
        /// </summary>
        public string zhize { get; set; }

        /// <summary>
        /// 职位类型id
        /// </summary>
        public int ZhiWeiTypeID { get; set; }

        /// <summary>
        /// 职位类型名称
        /// </summary>
        public string ZhiWeiTypeName { get; set; }

        #endregion Model

    }
}

