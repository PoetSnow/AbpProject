using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.Entities
{
    /// <summary>
    /// mic_ThumbnailSettings:ʵ����(��̨�ϴ�ͼƬ�Զ���������ͼ������Ϣ)
    /// </summary>
    [Table("Mic_ThumbnailSettings")]
    public  class Mic_ThumbnailSettings : Entity
    {

        #region Model
        /// <summary>
        /// ����id (��Ŀ����ͼ���ñ�)
        /// </summary>
        [Column("ID")]
        public override int Id { get; set; }

        /// <summary>
        /// ��ĿFid
        /// </summary>
        public int Fid
        {
            set;
            get;
        }
        /// <summary>
        /// �����ֶ����� bpic-��ͼ spic-Сͼ �ȵ� Ĭ��Ϊbpic
        /// </summary>
        public string FEfieldName
        {
            set;
            get;
        }
        /// <summary>
        /// Ŀ���ļ�������
        /// </summary>
        public string FolderName
        {
            set;
            get;
        }
        /// <summary>
        /// ���
        /// </summary>
        public int Width
        {
            set;
            get;
        }
        /// <summary>
        /// �߶�
        /// </summary>
        public int Height
        {
            set;
            get;
        }
        /// <summary>
        /// �������� 1-�ȱ������� 2-���вü�
        /// </summary>
        public int Type
        {
            set;
            get;
        }
        /// <summary>
        /// ����״̬ 0-���� 1-����
        /// </summary>
        public bool Status
        {
            set;
            get;
        }
        /// <summary>
        /// ����ͼ��� 1-��Ŀ��������ͼ 2-��ͼ��������ͼ
        /// </summary>
        public int PartType
        {
            set;
            get;
        }
        /// <summary>
        /// ��ע˵��
        /// </summary>
        public string Remarks
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

