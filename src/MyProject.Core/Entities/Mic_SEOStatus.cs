using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.Entities
{
	/// <summary>
    /// mic_SEOStatus:ʵ����(SEO�Ż�״̬���Ʊ�)
	/// </summary>
	[Table("Mic_SEOStatus")]
	public  class Mic_SEOStatus:Entity
	{

		#region Model
        /// <summary>
        /// ����ID (SEO�Ż�״̬���Ʊ�)
        /// </summary>
        public override int Id { get => base.Id; set => base.Id = value; }
      
		/// <summary>
		/// SEO�Ż�����״̬ 0-���� 1-����
		/// </summary>
		public bool Status
		{
            set;
            get;
		}
		#endregion Model

	}
}

