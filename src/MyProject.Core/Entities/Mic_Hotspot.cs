using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.Entities
{
	/// <summary>
    /// mic_Hotspot:ʵ����(ͼƬ������)
	/// </summary>
	[Table("Mic_Hotspot")]
	public  class Mic_Hotspot:Entity
	{
		
		#region Model
	
        /// <summary>
        /// ��������ID��ͼƬ������
        /// </summary>
        [Column("HID")]
        public override int Id { get; set; }

        /// <summary>
        /// ���Ftid Ĭ��Ϊ0
        /// </summary>
        public int Ftid { get; set; }

        /// <summary>
        /// ����/����
        /// </summary>
        public string HTitle { get; set; }

        /// <summary>
        /// ���ӵ�ַ
        /// </summary>
        public string HURL { get; set; }

        /// <summary>
        /// ͼƬ
        /// </summary>
        public string HPic { get; set; }

        /// <summary>
        /// �������(���Ͻ�) X ������ֵ Ĭ��Ϊ0
        /// </summary>
        public decimal HBeginX { get; set; }

        /// <summary>
        /// �������(���Ͻ�) Y ������ֵ Ĭ��Ϊ0
        /// </summary>
        public decimal HBeginY { get; set; }

        /// <summary>
        /// �յ�����(���½�) X ������ֵ Ĭ��Ϊ0
        /// </summary>
        public decimal HEndX { get; set; }

        /// <summary>
        /// �յ�����(���½�) Y ������ֵ Ĭ��Ϊ0
        /// </summary>
        public decimal HEndY { get; set; }

        /// <summary>
        /// ѡȡ��Χ��� Ĭ��Ϊ0
        /// </summary>
        public decimal HWidth { get; set; }

        /// <summary>
        /// ѡȡ��Χ�߶� Ĭ��Ϊ0
        /// </summary>
        public decimal HHeight { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public string HContent { get; set; }

        /// <summary>
        /// ״̬ 0-���� 1-��ʾ Ĭ��Ϊ1
        /// </summary>
        public int HStatus { get; set; }

        /// <summary>
        /// ��ע
        /// </summary>
        public string HRemark { get; set; }

        /// <summary>
        /// �ύʱ�� Ĭ��Ϊ��ǰʱ��
        /// </summary>
        public DateTime HDatetime { get; set; }
      
		#endregion Model

	}
}

