using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.Entities
{
	/// <summary>
    /// mic_National:ʵ����(�������ݱ�)
	/// </summary>
	[Serializable]
	public  class Mic_National:Entity
	{

		#region Model
        /// <summary>
        /// ����ID (�������ݱ�)
        /// </summary>
        [Column("ID")]
        public override int Id { get; set; }
   
		/// <summary>
		/// ���Ҵ���
		/// </summary>
		public string Code
		{
            set;
            get;
		}
		/// <summary>
		/// ��������
		/// </summary>
		public string CNName
		{
            set;
            get;
		}
		/// <summary>
		/// Ӣ������
		/// </summary>
		public string ENName
		{
            set;
            get;
		}
		/// <summary>
		/// ����ID
		/// </summary>
		public int OrderID
		{
            set;
            get;
		}
		#endregion Model

	}
}

