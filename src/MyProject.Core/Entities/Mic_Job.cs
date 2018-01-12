using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.Entities
{
    /// <summary>
    /// mic_Job:ʵ����(��Ƹ��Ϣ��)
    /// </summary>
    [Table("Mic_Job")]
    public  class Mic_Job : Entity
    {

        #region Model

        /// <summary>
        /// ����id (��Ƹ��Ϣ��)
        /// </summary>
        [Column("job_id")]
        public override int Id { get; set; }

        /// <summary>
        /// ְλ����
        /// </summary>
        public string job_name { get; set; }

        /// <summary>
        /// ��Ƹ���� У԰��Ƹ�������Ƹ
        /// </summary>
        public string job_type { get; set; }

        /// <summary>
        /// ��Ƹ���� 0-��ʾ���ɸ�
        /// </summary>
        public int job_pernuber { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public string job_bumen { get; set; }

        /// <summary>
        /// ������˾����
        /// </summary>
        public string job_companey { get; set; }

        /// <summary>
        /// ������˾id
        /// </summary>
        public int? job_companey_id { get; set; }

        /// <summary>
        /// �Ƿ��ö���ʾ
        /// </summary>
        public bool job_istop { get; set; }

        /// <summary>
        /// �Ƿ���ʾ 0-����ʾ 1-��ʾ
        /// </summary>
        public bool job_isshow { get; set; }


        /// <summary>
        /// ����ʱ�� 
        /// </summary>
        public DateTime date_time { get; set; }

        /// <summary>
        /// �����ص�
        /// </summary>
        public string job_adress { get; set; }

        /// <summary>
        /// ְλҪ��
        /// </summary>
        public string job_condition { get; set; }

        /// <summary>
        /// �Ա�Ҫ��
        /// </summary>
        public string job_sex { get; set; }

        /// <summary>
        /// ѧ��Ҫ��
        /// </summary>
        public string job_xueli { get; set; }

        /// <summary>
        /// רҵҪ��
        /// </summary>
        public string job_zhuanye { get; set; }

        /// <summary>
        /// ��н
        /// </summary>
        public string job_money { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime? guoqi { get; set; }

        /// <summary>
        /// ����ְ��
        /// </summary>
        public string zhize { get; set; }

        /// <summary>
        /// ְλ����id
        /// </summary>
        public int ZhiWeiTypeID { get; set; }

        /// <summary>
        /// ְλ��������
        /// </summary>
        public string ZhiWeiTypeName { get; set; }

        #endregion Model

    }
}

