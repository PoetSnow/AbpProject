using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.Entities
{
	/// <summary>
    /// mic_Role:实体类(角色表)
	/// </summary>
	[Table("Mic_Role")]
	public  class Mic_Role:Entity
	{

		#region Model
        /// <summary>
        /// 主键id (角色表)
        /// </summary>
        [Column("id")]
        public override int Id { get; set; }
      
		/// <summary>
		/// 角色名称
		/// </summary>
		public string role_name
		{
            set;
            get;
		}
		/// <summary>
		/// 角色描述
		/// </summary>
		public string role_description
		{
            set;
            get;
		}
		/// <summary>
		/// 提交时间
		/// </summary>
		public DateTime date_time
		{
            set;
            get;
		}
		#endregion Model

	}
}

