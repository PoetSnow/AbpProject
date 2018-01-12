
using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.Entities
{
    /// <summary>
    /// mic_Video:实体类(附件表)
    /// </summary>
    [Table("Mic_Video")]
    public  class Mic_Video : Entity
    {

        #region Model
        /// <summary>
        /// 主键ID (附件表)
        /// </summary>
        [Column("ID")]
        public override int Id { get => base.Id; set => base.Id = value; }

        /// <summary>
        /// 所属数据Ftid
        /// </summary>
        public int? Ftid
        {
            set;
            get;
        }
        /// <summary>
        /// 视频标题
        /// </summary>
        public string Title
        {
            set;
            get;
        }
        /// <summary>
        /// 小图
        /// </summary>
        public string SImg
        {
            set;
            get;
        }
        /// <summary>
        /// 大图
        /// </summary>
        public string BImg
        {
            set;
            get;
        }
        /// <summary>
        /// 视频文件路径
        /// </summary>
        public string FilePath
        {
            set;
            get;
        }
        /// <summary>
        /// 原始文件名
        /// </summary>
        public string OriginalFileName
        {
            set;
            get;
        }
        /// <summary>
        /// 内容描述
        /// </summary>
        public string Description
        {
            set;
            get;
        }
        /// <summary>
        /// 是否置顶
        /// </summary>
        public bool IsTop
        {
            set;
            get;
        }
        /// <summary>
        /// 加入时间
        /// </summary>
        public DateTime JoinDatetime
        {
            set;
            get;
        }
        /// <summary>
        /// 图片类型TypeID
        /// </summary>
        public int? TypeId
        {
            set;
            get;
        }
        /// <summary>
        /// 图片类型名称
        /// </summary>
        public string TypeName
        {
            set;
            get;
        }
        #endregion Model

    }
}

