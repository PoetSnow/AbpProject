using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.Entities
{
	/// <summary>
    /// mic_GetJob:实体类(应聘信息表)
	/// </summary>
	[Table("Mic_GetJob")]
	public  class Mic_GetJob:Entity
	{

		#region Model
		
        /// <summary>
        /// 主键id (应聘信息表)
        /// </summary>
        [Column("WorkperID")]
        public override int Id { get; set; }

        /// <summary>
        /// 真实姓名
        /// </summary>
        public string TureName { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public string Sex { get; set; }

        /// <summary>
        /// 身份证号码
        /// </summary>
        public string PersenCard { get; set; }

        /// <summary>
        /// 出生日期
        /// </summary>
        public string Birthday { get; set; }

        /// <summary>
        /// 出生地址
        /// </summary>
        public string BirthAddress { get; set; }

        /// <summary>
        /// 民族
        /// </summary>
        public string Nation { get; set; }

        /// <summary>
        /// 联系地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 婚姻状况
        /// </summary>
        public string Marry { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// E-mail
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 毕业院校
        /// </summary>
        public string School { get; set; }

        /// <summary>
        /// 毕业时间
        /// </summary>
        public string LeaveTime { get; set; }

        /// <summary>
        /// 专业
        /// </summary>
        public string ZhuanYe { get; set; }

        /// <summary>
        /// 学历
        /// </summary>
        public string XueLi { get; set; }

        /// <summary>
        /// 计算机
        /// </summary>
        public string Computer { get; set; }

        /// <summary>
        /// 计算机登记
        /// </summary>
        public string ComputerLevel { get; set; }

        /// <summary>
        /// 外语类型
        /// </summary>
        public string Languages { get; set; }

        /// <summary>
        /// 外语等级
        /// </summary>
        public string LanguageLevel { get; set; }

        /// <summary>
        /// 应聘岗位名称
        /// </summary>
        public string WorkName { get; set; }

        /// <summary>
        /// 应聘岗位id
        /// </summary>
        public int WorkID { get; set; }

        /// <summary>
        /// 要求月薪
        /// </summary>
        public string Money { get; set; }

        /// <summary>
        /// 自我介绍
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 教育经历
        /// </summary>
        public string SchoolDetail { get; set; }

        /// <summary>
        /// 工作经历
        /// </summary>
        public string WorkDetail { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 应聘职位类型id
        /// </summary>
        public int WorkTypeID { get; set; }

        /// <summary>
        /// 审核状态 0-未读 1-已读,未通过 2-已读,通过
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// 提交时间
        /// </summary>
        public DateTime DateAndTime { get; set; }
     
		#endregion Model

	}
}

