using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.Entities
{
    /// <summary>
    /// mic_Xun:ʵ����(��̬��Ŀ��)
    /// </summary>
    [Table("Mic_Xun")]
    public class Mic_Xun : Entity
    {

        #region Model
        /// <summary>
        /// ����id (��̬��Ŀ��)
        /// </summary>
        [Column("Id")]
        public override int Id { get => base.Id; set => base.Id = value; }

        /// <summary>
        /// ��Ŀ����
        /// </summary>
        public string Name
        {
            set;
            get;
        }
        /// <summary>
        /// ����id
        /// </summary>
        public int? Perent_id
        {
            set;
            get;
        }
        /// <summary>
        /// ���
        /// </summary>
        public string con
        {
            set;
            get;
        }
        #endregion Model

    }
}

