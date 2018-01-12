using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.Entities
{
	/// <summary>
    /// mic_Operation:ʵ����(��վ״̬���Ʊ�)
	/// </summary>
	[Table("Mic_Operation")]
	public  class Mic_Operation:Entity
	{

		#region Model
        /// <summary>
        /// ����id (��վ״̬���Ʊ�)
        /// </summary>
        [Column("ID")]
        public override int Id { get; set; }
      
		/// <summary>
		/// ��Ŀ����
		/// </summary>
		public string ColumnName
		{
            set;
            get;
		}
		/// <summary>
		/// ״̬ 0-���� 1-���ú�̨ 2-��վ�ر�
		/// </summary>
		public int Status
		{
            set;
            get;
		}
		/// <summary>
		/// ��ʾ��Ϣ
		/// </summary>
		public string MessageInfo
		{
            set;
            get;
		}
		#endregion Model

	}
}

