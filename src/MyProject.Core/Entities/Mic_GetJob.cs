using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.Entities
{
	/// <summary>
    /// mic_GetJob:ʵ����(ӦƸ��Ϣ��)
	/// </summary>
	[Table("Mic_GetJob")]
	public  class Mic_GetJob:Entity
	{

		#region Model
		
        /// <summary>
        /// ����id (ӦƸ��Ϣ��)
        /// </summary>
        [Column("WorkperID")]
        public override int Id { get; set; }

        /// <summary>
        /// ��ʵ����
        /// </summary>
        public string TureName { get; set; }

        /// <summary>
        /// �Ա�
        /// </summary>
        public string Sex { get; set; }

        /// <summary>
        /// ���֤����
        /// </summary>
        public string PersenCard { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public string Birthday { get; set; }

        /// <summary>
        /// ������ַ
        /// </summary>
        public string BirthAddress { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public string Nation { get; set; }

        /// <summary>
        /// ��ϵ��ַ
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// ����״��
        /// </summary>
        public string Marry { get; set; }

        /// <summary>
        /// ��ϵ�绰
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// E-mail
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// ��ҵԺУ
        /// </summary>
        public string School { get; set; }

        /// <summary>
        /// ��ҵʱ��
        /// </summary>
        public string LeaveTime { get; set; }

        /// <summary>
        /// רҵ
        /// </summary>
        public string ZhuanYe { get; set; }

        /// <summary>
        /// ѧ��
        /// </summary>
        public string XueLi { get; set; }

        /// <summary>
        /// �����
        /// </summary>
        public string Computer { get; set; }

        /// <summary>
        /// ������Ǽ�
        /// </summary>
        public string ComputerLevel { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public string Languages { get; set; }

        /// <summary>
        /// ����ȼ�
        /// </summary>
        public string LanguageLevel { get; set; }

        /// <summary>
        /// ӦƸ��λ����
        /// </summary>
        public string WorkName { get; set; }

        /// <summary>
        /// ӦƸ��λid
        /// </summary>
        public int WorkID { get; set; }

        /// <summary>
        /// Ҫ����н
        /// </summary>
        public string Money { get; set; }

        /// <summary>
        /// ���ҽ���
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public string SchoolDetail { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public string WorkDetail { get; set; }

        /// <summary>
        /// ��ע
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// ӦƸְλ����id
        /// </summary>
        public int WorkTypeID { get; set; }

        /// <summary>
        /// ���״̬ 0-δ�� 1-�Ѷ�,δͨ�� 2-�Ѷ�,ͨ��
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// �ύʱ��
        /// </summary>
        public DateTime DateAndTime { get; set; }
     
		#endregion Model

	}
}

