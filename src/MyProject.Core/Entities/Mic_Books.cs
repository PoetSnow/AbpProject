using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.Entities
{
    /// <summary>
    /// mic_Books:ʵ����(���Է�����Ϣ)
    /// </summary>

    [Table("Mic_Books")]
    public  class Mic_Books : Entity
    {


        /// <summary>
        /// ����ID
        /// </summary>
        [Column("Id")]
        public override int Id { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public virtual string Title { get; set; }

        /// <summary>
        /// ��˾����
        /// </summary>
        public virtual string Company_Name { get; set; }

        /// <summary>
        /// ��ϵ��
        /// </summary>
        public virtual string Contact { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public virtual string E_mail { get; set; }

        /// <summary>
        /// �绰
        /// </summary>
        public virtual string Tel { get; set; }

        /// <summary>
        /// ��˾��ַ
        /// </summary>
        public virtual string Company_Address { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// �ظ�
        /// </summary>
        public string HuiFu { get; set; }

        /// <summary>
        /// ����id 1-���� 2-Ͷ�� ��
        /// </summary>
        public int type { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public string typename { get; set; }

        /// <summary>
        /// ���״̬
        /// </summary>
        public bool Status { get; set; }

        /// <summary>
        /// �ύʱ��
        /// </summary>
        public DateTime date_time { get; set; }



    }
}

