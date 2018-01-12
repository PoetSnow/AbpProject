using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.Entities
{
    /// <summary>
    /// mic_Type:ʵ����(��̨��Ŀ��)
    /// </summary>
    [Table("Mic_Type")]
    public  class Mic_Type : Entity
    {



        #region Model
        /// <summary>
        /// ����id (��̨��Ŀ��)
        /// </summary>
        [Column("type_id")]
        public override int Id { get => base.Id; set => base.Id = value; }

        /// <summary>
        /// ��Ŀ����
        /// </summary>
        public string type_name
        {
            set;
            get;
        }
        /// <summary>
        /// ����id
        /// </summary>
        public int? parent_id
        {
            set;
            get;
        }
        /// <summary>
        /// ����
        /// </summary>
        public int order_id
        {
            set;
            get;
        }
        /// <summary>
        /// ������̬������Ŀid (mic_Xun������id)
        /// </summary>
        public int? n_id
        {
            set;
            get;
        }
        /// <summary>
        /// ���ӵ�ַ
        /// </summary>
        public string url
        {
            set;
            get;
        }
        /// <summary>
        /// ���ӵ�ַ(����ʹ�õ����ӵ�ַ)
        /// </summary>
        public string description
        {
            set;
            get;
        }
        /// <summary>
        /// Ԥ����ַ
        /// </summary>
        public string previewURL
        {
            set;
            get;
        }
        /// <summary>
        /// ������ 1-��ǰ���� 2-�´��� �ȵ�
        /// </summary>
        public int target
        {
            set;
            get;
        }
        /// <summary>
        /// ��ʾ״̬ 0-���� 1-��ʾ
        /// </summary>
        public bool display
        {
            set;
            get;
        }
        #endregion Model


        public Mic_Type() { }

        /// <summary>
        /// ���������캯��
        /// </summary>
        /// <param name="_type_name"></param>
        /// <param name="_parent_id"></param>
        /// <param name="_order_id"></param>
        /// <param name="_n_id"></param>
        /// <param name="_url"></param>
        /// <param name="_description"></param>
        /// <param name="_previewURL"></param>
        /// <param name="_target"></param>
        /// <param name="_display"></param>
        public Mic_Type(string _type_name,int _parent_id,int _order_id,
            int _n_id,string  _url,string _description,string _previewURL, int _target, bool _display)
        {
            type_name = _type_name;
            parent_id = _parent_id;
            order_id = _order_id;
            n_id = _n_id;
            url = _url;
            description = _description;
            previewURL = _previewURL;
            target = _target;
            display = _display;
        }

    }
}

