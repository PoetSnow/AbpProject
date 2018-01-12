using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.Entities
{
	/// <summary>
    /// mic_Mimages:实体类(配图数据表)
	/// </summary>
	[Table("Mic_Mimages")]
	public  class Mic_Mimages:Entity
	{

		#region Model
	
        /// <summary>
        /// 主键id (配图数据表)
        /// </summary>
        [Column("img_id")]
        public override int Id { get; set; }

        /// <summary>
        /// 所属数据Ftid
        /// </summary>
        public int FTid { get; set; }

        /// <summary>
        /// 中文标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 英文标题
        /// </summary>
        public string EnTitle { get; set; }

        /// <summary>
        /// 小图
        /// </summary>
        public string min_img { get; set; }

        /// <summary>
        /// 大图
        /// </summary>
        public string max_img { get; set; }

        /// <summary>
        /// 置顶
        /// </summary>
        public bool is_top { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 类型TypeID
        /// </summary>
        public int TypeID { get; set; }

        /// <summary>
        /// 类型名称
        /// </summary>
        public string TypeName { get; set; }

        /// <summary>
        /// 录入时间
        /// </summary>
        public DateTime date_time { get; set; }
        
		#endregion Model

	}
}

