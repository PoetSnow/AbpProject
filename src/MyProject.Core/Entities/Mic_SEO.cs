using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.Entities
{
	/// <summary>
    /// mic_SEO:实体类(SEO优化设置表)
	/// </summary>
	[Table("Mic_SEO")]
	public  class Mic_SEO:Entity
	{

		#region Model
        /// <summary>
        /// 主键ID (SEO优化设置表)
        /// </summary>
        public override int Id { get => base.Id ; set => base.Id = value; }
  
		/// <summary>
		/// 页面标题
		/// </summary>
		public string PageTitle
		{
            set;
            get;
		}
		/// <summary>
		/// 页面关键词
		/// </summary>
		public string Keywords
		{
            set;
            get;
		}
		/// <summary>
		/// 页面描述
		/// </summary>
		public string Description
		{
            set;
            get;
		}
		/// <summary>
		/// 备注信息
		/// </summary>
		public string Remarks
		{
            set;
            get;
		}
		/// <summary>
		/// 是否显示
		/// </summary>
		public bool IsShow
		{
            set;
            get;
		}
		/// <summary>
		/// 提交时间
		/// </summary>
		public DateTime JoinDatetime
		{
            set;
            get;
		}
		#endregion Model

	}
}

