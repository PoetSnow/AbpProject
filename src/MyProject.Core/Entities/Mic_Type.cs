using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.Entities
{
    /// <summary>
    /// mic_Type:实体类(后台栏目表)
    /// </summary>
    [Table("Mic_Type")]
    public  class Mic_Type : Entity
    {



        #region Model
        /// <summary>
        /// 主键id (后台栏目表)
        /// </summary>
        [Column("type_id")]
        public override int Id { get => base.Id; set => base.Id = value; }

        /// <summary>
        /// 栏目名称
        /// </summary>
        public string type_name
        {
            set;
            get;
        }
        /// <summary>
        /// 父级id
        /// </summary>
        public int? parent_id
        {
            set;
            get;
        }
        /// <summary>
        /// 排序
        /// </summary>
        public int order_id
        {
            set;
            get;
        }
        /// <summary>
        /// 所属动态配置栏目id (mic_Xun表主键id)
        /// </summary>
        public int? n_id
        {
            set;
            get;
        }
        /// <summary>
        /// 链接地址
        /// </summary>
        public string url
        {
            set;
            get;
        }
        /// <summary>
        /// 链接地址(现在使用的链接地址)
        /// </summary>
        public string description
        {
            set;
            get;
        }
        /// <summary>
        /// 预览地址
        /// </summary>
        public string previewURL
        {
            set;
            get;
        }
        /// <summary>
        /// 打开类型 1-当前窗口 2-新窗口 等等
        /// </summary>
        public int target
        {
            set;
            get;
        }
        /// <summary>
        /// 显示状态 0-隐藏 1-显示
        /// </summary>
        public bool display
        {
            set;
            get;
        }
        #endregion Model


        public Mic_Type() { }

        /// <summary>
        /// 待参数构造函数
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

