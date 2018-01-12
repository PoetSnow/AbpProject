using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.Entities
{
	/// <summary>
    /// mic_Projects:实体类(项目动态表)
	/// </summary>
	[Table("Mic_Projects")]
	public  class Mic_Projects:Entity
	{

		#region Model
        /// <summary>
        /// 主键id (项目动态表)
        /// </summary>
        [Column("id")]
        public override int Id { get; set; }
       
		/// <summary>
		/// 所属数据ftid
		/// </summary>
		public int FTid
		{
            set;
            get;
		}
		/// <summary>
		/// 标题
		/// </summary>
		public string P_title
		{
            set;
            get;
		}
		/// <summary>
		/// 图片
		/// </summary>
		public string P_img
		{
            set;
            get;
		}
		/// <summary>
		/// 内容
		/// </summary>
		public string P_content
		{
            set;
            get;
		}
		/// <summary>
		/// 是否置顶
		/// </summary>
		public bool P_istop
		{
            set;
            get;
		}
		/// <summary>
		/// 提交时间
		/// </summary>
		public DateTime P_datetime
		{
            set;
            get;
		}
		#endregion Model

	}
}

