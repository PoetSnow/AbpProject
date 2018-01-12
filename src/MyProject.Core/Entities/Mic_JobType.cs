using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.Entities
{
    /// <summary>
    /// mic_JobType:实体类(职位类型表)
    /// </summary>
    [Table("Mic_JobType")]
    public  class Mic_JobType : Entity
    {

        #region Model
        /// <summary>
        /// 主键id (职位类型表)
        /// </summary>

        [Column("ID")]
        public override int Id { get; set; }

        /// <summary>
        /// 类型名称
        /// </summary>
        public string TypeName { get; set; }

        /// <summary>
        /// 提交时间
        /// </summary>
        public DateTime JoinDatetime { get; set; }
       
        #endregion Model

    }
}

