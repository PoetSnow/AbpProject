using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Entities
{
    /// <summary>
    /// mic_Area:实体类(地区信息表)
    /// </summary>
    [Table("Mic_Area")]
    public class Mic_Area : Entity
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        [Column("AreaID")]
        public override int Id { get; set; }

        /// <summary>
        /// 行政区代码
        /// </summary>
        public virtual int AreaCode { get; set; }

        /// <summary>
        /// 地区名称
        /// </summary>
        public virtual string AreaName { get; set; }

        /// <summary>
        /// 父级ID
        /// </summary>
        public virtual int AreaParentID { get; set; }

        /// <summary>
        /// 父级Code
        /// </summary>
        public virtual string AreaParentCode { get; set; }
        /// <summary>
        /// 当前级别ID
        /// </summary>
        public virtual int AreaLevelID { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public virtual int AreaOrderID { get; set; }
    }
}

