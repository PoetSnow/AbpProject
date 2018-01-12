using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.Entities
{
    /// <summary>
    /// mic_UR:ʵ����(����Ա��ɫ�����)
    /// </summary>
    [Table("Mic_UR")]
    public  class Mic_UR : Entity
    {

        #region Model
        /// <summary>
        /// ����id (����Ա��ɫ�����)
        /// </summary>
        [Column("id")]
        public override int Id { get => base.Id; set => base.Id = value; }

        /// <summary>
        /// ����Ա�û���
        /// </summary>
        public string username
        {
            set;
            get;
        }
        /// <summary>
        /// ������ɫ����
        /// </summary>
        public string role_name
        {
            set;
            get;
        }
        /// <summary>
        /// ������ɫid
        /// </summary>
        public int? role_id
        {
            set;
            get;
        }
        /// <summary>
        /// ��ע˵��
        /// </summary>
        public string description
        {
            set;
            get;
        }
        #endregion Model

    }
}

