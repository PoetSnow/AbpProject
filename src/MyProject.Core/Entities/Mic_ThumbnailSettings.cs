using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.Entities
{
    /// <summary>
    /// mic_ThumbnailSettings:实体类(后台上传图片自动生成缩略图配置信息)
    /// </summary>
    [Table("Mic_ThumbnailSettings")]
    public  class Mic_ThumbnailSettings : Entity
    {

        #region Model
        /// <summary>
        /// 主键id (栏目缩略图配置表)
        /// </summary>
        [Column("ID")]
        public override int Id { get; set; }

        /// <summary>
        /// 栏目Fid
        /// </summary>
        public int Fid
        {
            set;
            get;
        }
        /// <summary>
        /// 所属字段名称 bpic-大图 spic-小图 等等 默认为bpic
        /// </summary>
        public string FEfieldName
        {
            set;
            get;
        }
        /// <summary>
        /// 目标文件夹名称
        /// </summary>
        public string FolderName
        {
            set;
            get;
        }
        /// <summary>
        /// 宽度
        /// </summary>
        public int Width
        {
            set;
            get;
        }
        /// <summary>
        /// 高度
        /// </summary>
        public int Height
        {
            set;
            get;
        }
        /// <summary>
        /// 生成类型 1-等比例缩放 2-居中裁剪
        /// </summary>
        public int Type
        {
            set;
            get;
        }
        /// <summary>
        /// 启用状态 0-禁用 1-启用
        /// </summary>
        public bool Status
        {
            set;
            get;
        }
        /// <summary>
        /// 缩略图类别 1-栏目数据缩略图 2-配图数据缩略图
        /// </summary>
        public int PartType
        {
            set;
            get;
        }
        /// <summary>
        /// 备注说明
        /// </summary>
        public string Remarks
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

