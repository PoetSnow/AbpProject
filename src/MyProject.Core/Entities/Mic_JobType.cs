using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.Entities
{
    /// <summary>
    /// mic_JobType:ʵ����(ְλ���ͱ�)
    /// </summary>
    [Table("Mic_JobType")]
    public  class Mic_JobType : Entity
    {

        #region Model
        /// <summary>
        /// ����id (ְλ���ͱ�)
        /// </summary>

        [Column("ID")]
        public override int Id { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public string TypeName { get; set; }

        /// <summary>
        /// �ύʱ��
        /// </summary>
        public DateTime JoinDatetime { get; set; }
       
        #endregion Model

    }
}

