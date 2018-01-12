using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.Entities
{
    /// <summary>
    /// mic_FEditStyle:ʵ����(��̬�ֶ����ñ�)
    /// </summary>
   [Table("Mic_FEditStyle")]
    public  class Mic_FEditStyle : Entity
    {

        #region Model
     
        /// <summary>
        /// ����ID (��̬�ֶ����ñ�)
        /// </summary>
        [Column("FEid")]
        public override int Id { get; set; }

        /// <summary>
        /// ���ݴ���ֶ�����
        /// </summary>
        public string FEfield { get; set; }

        /// <summary>
        /// ���ݴ���ֶ�����id
        /// </summary>
        public int? FEfieldid { get; set; }

        /// <summary>
        /// �ֶ�����
        /// </summary>
        public string FEmean { get; set; }

        /// <summary>
        /// �ı�����
        /// </summary>
        public string FEwidth { get; set; }

        /// <summary>
        /// �ı������Ƿ�Ϊ�ٷֱ� 0-�� 1-��
        /// </summary>
        public bool FEwidthPercent { get; set; }

        /// <summary>
        /// �ı���߶�
        /// </summary>
        public string FEheigth { get; set; }

        /// <summary>
        /// ��������(1-����,2-����,3-��ѡ,4-��ѡ,5-�����б�,6-ʱ��,7-ͼƬ)
        /// </summary>
        public int FErow { get; set; }

        /// <summary>
        /// �Ƿ�Ϊ������
        /// </summary>
        public bool FEmust { get; set; }

        /// <summary>
        /// Ĭ��ֵ
        /// </summary>
        public string FEpos { get; set; }

        /// <summary>
        /// �����������ʾ˵��
        /// </summary>
        public string FEex { get; set; }

        /// <summary>
        /// ��ĿFid
        /// </summary>
        public int Fid { get; set; }

        /// <summary>
        /// ��ѡ,��ѡ,�����б�����ʱ����Դ��ĿFid
        /// </summary>
        public string FESourcesFid { get; set; }

        /// <summary>
        /// ����Դѡ��
        /// </summary>
        public string FESourcesItems { get; set; }

        /// <summary>
        /// ͼƬ
        /// </summary>
        public bool? FEtu { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public bool? FEbj { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public int FEOrderID { get; set; }

        #endregion Model

    }
}

