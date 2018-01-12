using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.Entities
{
	/// <summary>
    /// mic_Projects:ʵ����(��Ŀ��̬��)
	/// </summary>
	[Table("Mic_Projects")]
	public  class Mic_Projects:Entity
	{

		#region Model
        /// <summary>
        /// ����id (��Ŀ��̬��)
        /// </summary>
        [Column("id")]
        public override int Id { get; set; }
       
		/// <summary>
		/// ��������ftid
		/// </summary>
		public int FTid
		{
            set;
            get;
		}
		/// <summary>
		/// ����
		/// </summary>
		public string P_title
		{
            set;
            get;
		}
		/// <summary>
		/// ͼƬ
		/// </summary>
		public string P_img
		{
            set;
            get;
		}
		/// <summary>
		/// ����
		/// </summary>
		public string P_content
		{
            set;
            get;
		}
		/// <summary>
		/// �Ƿ��ö�
		/// </summary>
		public bool P_istop
		{
            set;
            get;
		}
		/// <summary>
		/// �ύʱ��
		/// </summary>
		public DateTime P_datetime
		{
            set;
            get;
		}
		#endregion Model

	}
}

