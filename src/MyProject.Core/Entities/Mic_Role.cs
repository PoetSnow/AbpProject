using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.Entities
{
	/// <summary>
    /// mic_Role:ʵ����(��ɫ��)
	/// </summary>
	[Table("Mic_Role")]
	public  class Mic_Role:Entity
	{

		#region Model
        /// <summary>
        /// ����id (��ɫ��)
        /// </summary>
        [Column("id")]
        public override int Id { get; set; }
      
		/// <summary>
		/// ��ɫ����
		/// </summary>
		public string role_name
		{
            set;
            get;
		}
		/// <summary>
		/// ��ɫ����
		/// </summary>
		public string role_description
		{
            set;
            get;
		}
		/// <summary>
		/// �ύʱ��
		/// </summary>
		public DateTime date_time
		{
            set;
            get;
		}
		#endregion Model

	}
}

