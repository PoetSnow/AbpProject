using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.Entities
{
    /// <summary>
    /// mic_FEditStyle:实体类(动态字段配置表)
    /// </summary>
   [Table("Mic_FEditStyle")]
    public  class Mic_FEditStyle : Entity
    {

        #region Model
     
        /// <summary>
        /// 主键ID (动态字段配置表)
        /// </summary>
        [Column("FEid")]
        public override int Id { get; set; }

        /// <summary>
        /// 内容存放字段名称
        /// </summary>
        public string FEfield { get; set; }

        /// <summary>
        /// 内容存放字段名称id
        /// </summary>
        public int? FEfieldid { get; set; }

        /// <summary>
        /// 字段意义
        /// </summary>
        public string FEmean { get; set; }

        /// <summary>
        /// 文本框宽度
        /// </summary>
        public string FEwidth { get; set; }

        /// <summary>
        /// 文本框宽度是否为百分比 0-否 1-是
        /// </summary>
        public bool FEwidthPercent { get; set; }

        /// <summary>
        /// 文本框高度
        /// </summary>
        public string FEheigth { get; set; }

        /// <summary>
        /// 内容类型(1-单行,2-多行,3-单选,4-多选,5-下拉列表,6-时间,7-图片)
        /// </summary>
        public int FErow { get; set; }

        /// <summary>
        /// 是否为必填项
        /// </summary>
        public bool FEmust { get; set; }

        /// <summary>
        /// 默认值
        /// </summary>
        public string FEpos { get; set; }

        /// <summary>
        /// 填表事例及提示说明
        /// </summary>
        public string FEex { get; set; }

        /// <summary>
        /// 栏目Fid
        /// </summary>
        public int Fid { get; set; }

        /// <summary>
        /// 单选,多选,下拉列表类型时数据源栏目Fid
        /// </summary>
        public string FESourcesFid { get; set; }

        /// <summary>
        /// 数据源选项
        /// </summary>
        public string FESourcesItems { get; set; }

        /// <summary>
        /// 图片
        /// </summary>
        public bool? FEtu { get; set; }

        /// <summary>
        /// 背景
        /// </summary>
        public bool? FEbj { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int FEOrderID { get; set; }

        #endregion Model

    }
}

