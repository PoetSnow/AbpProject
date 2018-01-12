using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.Entities
{
	/// <summary>
    /// mic_Operation:实体类(网站状态控制表)
	/// </summary>
	[Table("Mic_Operation")]
	public  class Mic_Operation:Entity
	{

		#region Model
        /// <summary>
        /// 主键id (网站状态控制表)
        /// </summary>
        [Column("ID")]
        public override int Id { get; set; }
      
		/// <summary>
		/// 栏目名称
		/// </summary>
		public string ColumnName
		{
            set;
            get;
		}
		/// <summary>
		/// 状态 0-启用 1-禁用后台 2-网站关闭
		/// </summary>
		public int Status
		{
            set;
            get;
		}
		/// <summary>
		/// 提示消息
		/// </summary>
		public string MessageInfo
		{
            set;
            get;
		}
		#endregion Model

	}
}

