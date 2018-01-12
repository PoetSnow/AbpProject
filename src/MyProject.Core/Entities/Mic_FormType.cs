using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.Entities
{
    /// <summary>
    /// mic_FormType:ʵ����(Fid,��Ŀģ���)
    /// </summary>
    [Table("Mic_FormType")]
    public  class Mic_FormType : Entity
    {
        public Mic_FormType()
        { }
        #region Model
        



        /// <summary>
        /// ��Ŀ��������
        /// </summary>
        public string Ftype { get; set; }

        /// <summary>
        /// ��Ŀ����id
        /// </summary>
        public int? Ftypeid { get; set; }

        /// <summary>
        /// ��Ŀ����
        /// </summary>
        public string Fname { get; set; }

        /// <summary>
        /// ��Ŀ��ע
        /// </summary>
        public string Fintro { get; set; }

        /// <summary>
        /// �Ƿ���ʾСͼ�ϴ� 0-����ʾ 1-��ʾ Ĭ��Ϊ0
        /// </summary>
        public bool Fistu1 { get; set; }

        /// <summary>
        /// �Ƿ���ʾ��ͼ�ϴ� 0-����ʾ 1-��ʾ Ĭ��Ϊ0
        /// </summary>
        public bool Fistu2 { get; set; }

        /// <summary>
        /// �Ƿ���ʾ����ͼƬ�ϴ� 0-����ʾ 1-��ʾ Ĭ��Ϊ0
        /// </summary>
        public bool Fistu3 { get; set; }

        /// <summary>
        /// �Ƿ���ʾ��ͼ�ϴ� 0-����ʾ 1-��ʾ Ĭ��Ϊ0
        /// </summary>
        public bool F_pt { get; set; }

        /// <summary>
        /// �Ƿ���ʾ��Ŀ��̬�ϴ� 0-����ʾ 1-��ʾ Ĭ��Ϊ0
        /// </summary>
        public bool F_xmdt { get; set; }

        /// <summary>
        /// �Ƿ���ʾ�����ϴ� 0-����ʾ 1-��ʾ Ĭ��Ϊ0
        /// </summary>
        public bool F_ysgg { get; set; }

        /// <summary>
        /// �Ƿ���ʾ�༭�� 0-����ʾ 1-��ʾ Ĭ��Ϊ0
        /// </summary>
        public bool Fiscontent { get; set; }

        /// <summary>
        /// �Ƿ���ʾ���ݷ���20 0-����ʾ 1-��ʾ Ĭ��Ϊ0
        /// </summary>
        public bool Fdatatype { get; set; }

        /// <summary>
        /// Сͼ˵��
        /// </summary>
        public string FEtudes1 { get; set; }

        /// <summary>
        /// ��ͼ˵��
        /// </summary>
        public string FEtudes2 { get; set; }

        /// <summary>
        /// ����ͼƬ˵��
        /// </summary>
        public string FEtudes3 { get; set; }

        /// <summary>
        /// ��ͼСͼ˵��
        /// </summary>
        public string FSpictures { get; set; }

        /// <summary>
        /// ��ͼ��ͼ˵��
        /// </summary>
        public string FBpictures { get; set; }

        /// <summary>
        /// �Ƿ���ʾ�������19 0-����ʾ 1-��ʾ Ĭ��Ϊ0
        /// </summary>
        public bool Fcom { get; set; }

        /// <summary>
        /// �Ƿ���ʾ�ϴ�ʱ���ֶ�  0-����ʾ 1-��ʾ Ĭ��Ϊ1
        /// </summary>
        public bool Fdate { get; set; }

        /// <summary>
        /// �Ƿ���ʾ�½���ť  0-����ʾ 1-��ʾ Ĭ��Ϊ1
        /// </summary>
        public bool Fadd { get; set; }

        /// <summary>
        /// �Ƿ���ʾ�޸ı༭��ť  0-����ʾ 1-��ʾ Ĭ��Ϊ1
        /// </summary>
        public bool Fupdate { get; set; }

        /// <summary>
        /// �Ƿ���ʾɾ����ť  0-����ʾ 1-��ʾ Ĭ��Ϊ1
        /// </summary>
        public bool Fdelete { get; set; }

        /// <summary>
        /// ��mic_Xun���е�����id
        /// </summary>
        [Column("Id")]
        public int XId { get; set; }
    
		#endregion Model

	}
}

