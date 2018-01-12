using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.Entities
{
    /// <summary>
    /// mic_Note:ʵ����(��¼��־��)
    /// </summary>
    [Serializable]
    public  class Mic_Note : Entity
    {

        #region Model
        /// <summary>
        /// ����id (��¼��־�� )
        /// </summary>

        [Column("id")]
        public override int Id { get; set; }

        /// <summary>
        /// ��¼�û���
        /// </summary>
        public string username
        {
            set;
            get;
        }
        /// <summary>
        /// ��¼ʱ��
        /// </summary>
        public DateTime date_time
        {
            set;
            get;
        }
        /// <summary>
        /// ��¼IP��ַ
        /// </summary>
        public string user_ip
        {
            set;
            get;
        }
        /// <summary>
        /// ״̬ 1-��¼�ɹ�
        /// </summary>
        public int Success
        {
            set;
            get;
        }
        #endregion Model

    }
}

