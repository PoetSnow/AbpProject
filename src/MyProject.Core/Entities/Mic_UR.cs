using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.Entities
{
    /// <summary>
    /// mic_UR:实体类(管理员角色分配表)
    /// </summary>
    [Table("Mic_UR")]
    public  class Mic_UR : Entity
    {

        #region Model
        /// <summary>
        /// 主键id (管理员角色分配表)
        /// </summary>
        [Column("id")]
        public override int Id { get => base.Id; set => base.Id = value; }

        /// <summary>
        /// 管理员用户名
        /// </summary>
        public string username
        {
            set;
            get;
        }
        /// <summary>
        /// 所属角色名称
        /// </summary>
        public string role_name
        {
            set;
            get;
        }
        /// <summary>
        /// 所属角色id
        /// </summary>
        public int? role_id
        {
            set;
            get;
        }
        /// <summary>
        /// 备注说明
        /// </summary>
        public string description
        {
            set;
            get;
        }
        #endregion Model

    }
}

