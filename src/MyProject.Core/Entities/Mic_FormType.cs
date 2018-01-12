using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.Entities
{
    /// <summary>
    /// mic_FormType:实体类(Fid,栏目模版表单)
    /// </summary>
    [Table("Mic_FormType")]
    public  class Mic_FormType : Entity
    {
        public Mic_FormType()
        { }
        #region Model
        



        /// <summary>
        /// 栏目类型名称
        /// </summary>
        public string Ftype { get; set; }

        /// <summary>
        /// 栏目类型id
        /// </summary>
        public int? Ftypeid { get; set; }

        /// <summary>
        /// 栏目名称
        /// </summary>
        public string Fname { get; set; }

        /// <summary>
        /// 栏目备注
        /// </summary>
        public string Fintro { get; set; }

        /// <summary>
        /// 是否显示小图上传 0-不显示 1-显示 默认为0
        /// </summary>
        public bool Fistu1 { get; set; }

        /// <summary>
        /// 是否显示大图上传 0-不显示 1-显示 默认为0
        /// </summary>
        public bool Fistu2 { get; set; }

        /// <summary>
        /// 是否显示热区图片上传 0-不显示 1-显示 默认为0
        /// </summary>
        public bool Fistu3 { get; set; }

        /// <summary>
        /// 是否显示配图上传 0-不显示 1-显示 默认为0
        /// </summary>
        public bool F_pt { get; set; }

        /// <summary>
        /// 是否显示项目动态上传 0-不显示 1-显示 默认为0
        /// </summary>
        public bool F_xmdt { get; set; }

        /// <summary>
        /// 是否显示附件上传 0-不显示 1-显示 默认为0
        /// </summary>
        public bool F_ysgg { get; set; }

        /// <summary>
        /// 是否显示编辑器 0-不显示 1-显示 默认为0
        /// </summary>
        public bool Fiscontent { get; set; }

        /// <summary>
        /// 是否显示数据分类20 0-不显示 1-显示 默认为0
        /// </summary>
        public bool Fdatatype { get; set; }

        /// <summary>
        /// 小图说明
        /// </summary>
        public string FEtudes1 { get; set; }

        /// <summary>
        /// 大图说明
        /// </summary>
        public string FEtudes2 { get; set; }

        /// <summary>
        /// 热区图片说明
        /// </summary>
        public string FEtudes3 { get; set; }

        /// <summary>
        /// 配图小图说明
        /// </summary>
        public string FSpictures { get; set; }

        /// <summary>
        /// 配图大图说明
        /// </summary>
        public string FBpictures { get; set; }

        /// <summary>
        /// 是否显示所属类别19 0-不显示 1-显示 默认为0
        /// </summary>
        public bool Fcom { get; set; }

        /// <summary>
        /// 是否显示上传时间字段  0-不显示 1-显示 默认为1
        /// </summary>
        public bool Fdate { get; set; }

        /// <summary>
        /// 是否显示新建按钮  0-不显示 1-显示 默认为1
        /// </summary>
        public bool Fadd { get; set; }

        /// <summary>
        /// 是否显示修改编辑按钮  0-不显示 1-显示 默认为1
        /// </summary>
        public bool Fupdate { get; set; }

        /// <summary>
        /// 是否显示删除按钮  0-不显示 1-显示 默认为1
        /// </summary>
        public bool Fdelete { get; set; }

        /// <summary>
        /// 在mic_Xun表中的主键id
        /// </summary>
        [Column("Id")]
        public int XId { get; set; }
    
		#endregion Model

	}
}

