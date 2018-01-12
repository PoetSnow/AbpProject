using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Entities
{
    [Table("Fall")]
    public class Fall : Entity
    {
        public Fall() { }
        /// <summary>
        /// 主键
        /// </summary>
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Ftid")]
        public override int Id { get; set; }

        /// <summary>
        /// 标题1
        /// </summary>
        [MaxLengthAttribute]
        public virtual string Ftitle1 { get; set; }

        /// <summary>
        /// 标题2
        /// </summary>
        [MaxLengthAttribute]
        public virtual string Ftitle2 { get; set; }

        /// <summary>
        /// 标题3
        /// </summary>
        [MaxLengthAttribute]
        public virtual string Ftitle3 { get; set; }

        /// <summary>
        /// 标题4
        /// </summary>
        [MaxLengthAttribute]
        public virtual string Ftitle4 { get; set; }

        /// <summary>
        /// 标题5
        /// </summary>
        [MaxLengthAttribute]
        public virtual string Ftitle5 { get; set; }

        /// <summary>
        /// 标题6
        /// </summary>
        [MaxLengthAttribute]
        public virtual string Ftitle6 { get; set; }

        /// <summary>
        /// 标题7
        /// </summary>
        [MaxLengthAttribute]
        public virtual string Ftitle7 { get; set; }

        /// <summary>
        /// 标题8
        /// </summary>
        [MaxLengthAttribute]
        public virtual string Ftitle8 { get; set; }

        /// <summary>
        /// 标题9
        /// </summary>
        [MaxLengthAttribute]
        public virtual string Ftitle9 { get; set; }

        /// <summary>
        /// 标题10
        /// </summary>
        [MaxLengthAttribute]
        public virtual string Ftitle10 { get; set; }

        /// <summary>
        /// 标题11
        /// </summary>
        [MaxLengthAttribute]
        public virtual string Ftitle11 { get; set; }

        /// <summary>
        /// 标题12
        /// </summary>
        [MaxLengthAttribute]
        public virtual string Ftitle12 { get; set; }

        /// <summary>
        /// 标题13
        /// </summary>
        [MaxLengthAttribute]
        public virtual string Ftitle13 { get; set; }

        /// <summary>
        /// 标题14
        /// </summary>
        [MaxLengthAttribute]
        public virtual string Ftitle14 { get; set; }

        /// <summary>
        /// 标题15
        /// </summary>
        [MaxLengthAttribute]
        public virtual string Ftitle15 { get; set; }

        /// <summary>
        /// 标题16
        /// </summary>
        [MaxLengthAttribute]
        public virtual string Ftitle16 { get; set; }

        /// <summary>
        /// 标题17
        /// </summary>
        [MaxLengthAttribute]
        public virtual string Ftitle17 { get; set; }

        /// <summary>
        /// 标题18
        /// </summary>
        [MaxLengthAttribute]
        public virtual string Ftitle18 { get; set; }

        /// <summary>
        /// 标题19
        /// </summary>
        [MaxLengthAttribute]
        public virtual string Ftitle19 { get; set; }

        /// <summary>
        /// 标题20
        /// </summary>
        [MaxLengthAttribute]
        public virtual string Ftitle20 { get; set; }

        /// <summary>
        /// 标题21
        /// </summary>
        [MaxLengthAttribute]
        public virtual string Ftitle21 { get; set; }

        /// <summary>
        /// 标题22
        /// </summary>
        [MaxLengthAttribute]
        public virtual string Ftitle22 { get; set; }

        /// <summary>
        /// 标题23
        /// </summary>
        [MaxLengthAttribute]
        public virtual string Ftitle23 { get; set; }

        /// <summary>
        /// 标题24
        /// </summary>
        [MaxLengthAttribute]
        public virtual string Ftitle24 { get; set; }

        /// <summary>
        /// 标题25
        /// </summary>
        [MaxLengthAttribute]
        public virtual string Ftitle25 { get; set; }

        /// <summary>
        /// 标题26
        /// </summary>
        [MaxLengthAttribute]
        public virtual string Ftitle26 { get; set; }

        /// <summary>
        /// 标题27
        /// </summary>
        [MaxLengthAttribute]
        public virtual string Ftitle27 { get; set; }

        /// <summary>
        /// 标题28
        /// </summary>
        [MaxLengthAttribute]
        public virtual string Ftitle28 { get; set; }
        /// <summary>
        /// 标题29
        /// </summary>
        [MaxLengthAttribute]
        public virtual string Ftitle29 { get; set; }
        /// <summary>
        /// 标题30
        /// </summary>
        [MaxLengthAttribute]
        public virtual string Ftitle30 { get; set; }

        /// <summary>
        /// 栏目ID
        /// </summary>
        [Required]
        public virtual int Fid { get; set; }

        /// <summary>
        /// 小图
        /// </summary>
        [MaxLength(50)]
        public string Fspic { get; set; }

        /// <summary>
        /// 大图
        /// </summary>
        [MaxLength(50)]
        public string Fbpic { get; set; }

        /// <summary>
        /// 详细信息
        /// </summary>
        [MaxLengthAttribute]
        public string Fcontent { get; set; }

        /// <summary>
        /// 栏目名称
        /// </summary>
        [MaxLength(50)]
        public string Fname { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Fdatetime { get; set; }

        /// <summary>
        /// 是否置顶
        /// </summary>
        [Required]
        public bool Fistop { get; set; }

        /// <summary>
        /// 所属公司id
        /// </summary>
        public int Companeyid { set; get; }

        /// <summary>
        /// 所属公司名称
        /// </summary>
        [MaxLength(50)]
        public string Companeyname { set; get; }

        /// <summary>
        /// 查看次数
        /// </summary>
        [Required]
        public int FViewNum { set; get; }
        /// <summary>
        /// 显示状态 0-不显示 1-显示
        /// </summary>
        [Required]
        public bool FisShow { set; get; }

        /// <summary>
        /// 删除状态 0-正常状态数据 1-删除状态数据
        /// </summary>
        [Required]
        public bool FisDel { set; get; }

        /// <summary>
        /// 排序
        /// </summary>
        [Required]
        public int FisSort { set; get; }
    }
}
