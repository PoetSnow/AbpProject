using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.Entities
{
	/// <summary>
    /// mic_National:实体类(国家数据表)
	/// </summary>
	[Serializable]
	public  class Mic_National:Entity
	{

		#region Model
        /// <summary>
        /// 主键ID (国家数据表)
        /// </summary>
        [Column("ID")]
        public override int Id { get; set; }
   
		/// <summary>
		/// 国家代码
		/// </summary>
		public string Code
		{
            set;
            get;
		}
		/// <summary>
		/// 中文名称
		/// </summary>
		public string CNName
		{
            set;
            get;
		}
		/// <summary>
		/// 英文名称
		/// </summary>
		public string ENName
		{
            set;
            get;
		}
		/// <summary>
		/// 排序ID
		/// </summary>
		public int OrderID
		{
            set;
            get;
		}
		#endregion Model

	}
}

