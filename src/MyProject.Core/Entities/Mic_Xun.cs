using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.Entities
{
    /// <summary>
    /// mic_Xun:实体类(动态栏目表)
    /// </summary>
    [Table("Mic_Xun")]
    public class Mic_Xun : Entity
    {

        #region Model
        /// <summary>
        /// 主键id (动态栏目表)
        /// </summary>
        [Column("Id")]
        public override int Id { get => base.Id; set => base.Id = value; }

        /// <summary>
        /// 栏目名称
        /// </summary>
        public string Name
        {
            set;
            get;
        }
        /// <summary>
        /// 父级id
        /// </summary>
        public int? Perent_id
        {
            set;
            get;
        }
        /// <summary>
        /// 简介
        /// </summary>
        public string con
        {
            set;
            get;
        }
        #endregion Model

    }
}

