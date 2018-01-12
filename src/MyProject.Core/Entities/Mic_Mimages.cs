using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.Entities
{
	/// <summary>
    /// mic_Mimages:ʵ����(��ͼ���ݱ�)
	/// </summary>
	[Table("Mic_Mimages")]
	public  class Mic_Mimages:Entity
	{

		#region Model
	
        /// <summary>
        /// ����id (��ͼ���ݱ�)
        /// </summary>
        [Column("img_id")]
        public override int Id { get; set; }

        /// <summary>
        /// ��������Ftid
        /// </summary>
        public int FTid { get; set; }

        /// <summary>
        /// ���ı���
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Ӣ�ı���
        /// </summary>
        public string EnTitle { get; set; }

        /// <summary>
        /// Сͼ
        /// </summary>
        public string min_img { get; set; }

        /// <summary>
        /// ��ͼ
        /// </summary>
        public string max_img { get; set; }

        /// <summary>
        /// �ö�
        /// </summary>
        public bool is_top { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// ����TypeID
        /// </summary>
        public int TypeID { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public string TypeName { get; set; }

        /// <summary>
        /// ¼��ʱ��
        /// </summary>
        public DateTime date_time { get; set; }
        
		#endregion Model

	}
}

