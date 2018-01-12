using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.Entities
{
    /// <summary>
    /// mic_ColumnOperation:ʵ����(��ɫ��ɾ���Լ��������ݲ���Ȩ�ޱ�)
    /// </summary>
    [Table("Mic_ColumnOperation")]
    public  class Mic_ColumnOperation: Entity
    {

        #region Model


        /// <summary>
        /// ����ID (��ɫ��ɾ���Լ��������ݲ���Ȩ�ޱ�)
        /// </summary>
        [Column("Id")]
        public override int Id { get; set; }
	
	
		/// <summary>
		/// ��ɫid
		/// </summary>
	
        public int role_Id { get; set; }
        /// <summary>
        /// ��Ŀtype_id
        /// </summary>
        public int type_Id { get; set; }

        /// <summary>
        /// �Ƿ��������Ӳ���
        /// </summary>
        public bool C_add { get; set; }

        /// <summary>
        /// �Ƿ������޸Ĳ���
        /// </summary>
        public bool C_update { get; set; }

        /// <summary>
        /// �Ƿ�����ɾ������
        /// </summary>
        public bool C_delete { get; set; }

        /// <summary>
        /// ������������(����SQL���)
        /// </summary>
        public string C_datatype { get; set; }
      
		#endregion Model

	}
}

