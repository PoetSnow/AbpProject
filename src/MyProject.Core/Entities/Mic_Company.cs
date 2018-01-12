using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.Entities
{
    /// <summary>
    /// mic_Company:ʵ����(��˾�����)
    /// </summary>
    [Table("Mic_Company")]
    public  class Mic_Company : Entity
    {

        #region Model
    
        /// <summary>
        /// ����ID (��˾�����)
        /// </summary>
        [Column("companey_id")]
        public override int Id { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public string companey_name { get; set; }

        /// <summary>
        /// ��ַ
        /// </summary>
        public string companey_address { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public int companey_order { get; set; }

        /// <summary>
        /// ͼƬ
        /// </summary>
        public string companey_image { get; set; }

        /// <summary>
        /// ��˾����
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// ���ʱ��
        /// </summary>
        public DateTime companey_datetime { get; set; }

        /// <summary>
        /// ��ϵ�绰
        /// </summary>
        public string companey_telepho { get; set; }

        /// <summary>
        /// �ʱ�
        /// </summary>
        public string companey_youbian { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public string companey_chuanzhen { get; set; }

        /// <summary>
        /// E-mail
        /// </summary>
        public string companey_email { get; set; }
  
        #endregion Model

    }
}

