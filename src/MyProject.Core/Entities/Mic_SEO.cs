using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.Entities
{
	/// <summary>
    /// mic_SEO:ʵ����(SEO�Ż����ñ�)
	/// </summary>
	[Table("Mic_SEO")]
	public  class Mic_SEO:Entity
	{

		#region Model
        /// <summary>
        /// ����ID (SEO�Ż����ñ�)
        /// </summary>
        public override int Id { get => base.Id ; set => base.Id = value; }
  
		/// <summary>
		/// ҳ�����
		/// </summary>
		public string PageTitle
		{
            set;
            get;
		}
		/// <summary>
		/// ҳ��ؼ���
		/// </summary>
		public string Keywords
		{
            set;
            get;
		}
		/// <summary>
		/// ҳ������
		/// </summary>
		public string Description
		{
            set;
            get;
		}
		/// <summary>
		/// ��ע��Ϣ
		/// </summary>
		public string Remarks
		{
            set;
            get;
		}
		/// <summary>
		/// �Ƿ���ʾ
		/// </summary>
		public bool IsShow
		{
            set;
            get;
		}
		/// <summary>
		/// �ύʱ��
		/// </summary>
		public DateTime JoinDatetime
		{
            set;
            get;
		}
		#endregion Model

	}
}

