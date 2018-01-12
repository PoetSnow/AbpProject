using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.Entities
{
	/// <summary>
    /// mic_SEOStatus:实体类(SEO优化状态控制表)
	/// </summary>
	[Table("Mic_SEOStatus")]
	public  class Mic_SEOStatus:Entity
	{

		#region Model
        /// <summary>
        /// 主键ID (SEO优化状态控制表)
        /// </summary>
        public override int Id { get => base.Id; set => base.Id = value; }
      
		/// <summary>
		/// SEO优化启用状态 0-禁用 1-启用
		/// </summary>
		public bool Status
		{
            set;
            get;
		}
		#endregion Model

	}
}

