using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.Entities
{
	/// <summary>
    /// mic_Hotspot:实体类(图片热区表)
	/// </summary>
	[Table("Mic_Hotspot")]
	public  class Mic_Hotspot:Entity
	{
		
		#region Model
	
        /// <summary>
        /// 数据主键ID（图片热区表）
        /// </summary>
        [Column("HID")]
        public override int Id { get; set; }

        /// <summary>
        /// 外键Ftid 默认为0
        /// </summary>
        public int Ftid { get; set; }

        /// <summary>
        /// 标题/名称
        /// </summary>
        public string HTitle { get; set; }

        /// <summary>
        /// 链接地址
        /// </summary>
        public string HURL { get; set; }

        /// <summary>
        /// 图片
        /// </summary>
        public string HPic { get; set; }

        /// <summary>
        /// 起点坐标(左上角) X 横坐标值 默认为0
        /// </summary>
        public decimal HBeginX { get; set; }

        /// <summary>
        /// 起点坐标(左上角) Y 纵坐标值 默认为0
        /// </summary>
        public decimal HBeginY { get; set; }

        /// <summary>
        /// 终点坐标(右下角) X 横坐标值 默认为0
        /// </summary>
        public decimal HEndX { get; set; }

        /// <summary>
        /// 终点坐标(右下角) Y 纵坐标值 默认为0
        /// </summary>
        public decimal HEndY { get; set; }

        /// <summary>
        /// 选取范围宽度 默认为0
        /// </summary>
        public decimal HWidth { get; set; }

        /// <summary>
        /// 选取范围高度 默认为0
        /// </summary>
        public decimal HHeight { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public string HContent { get; set; }

        /// <summary>
        /// 状态 0-隐藏 1-显示 默认为1
        /// </summary>
        public int HStatus { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string HRemark { get; set; }

        /// <summary>
        /// 提交时间 默认为当前时间
        /// </summary>
        public DateTime HDatetime { get; set; }
      
		#endregion Model

	}
}

