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
    /// mic_Area:ʵ����(������Ϣ��)
    /// </summary>
    [Table("Mic_Area")]
    public class Mic_Area : Entity
    {
        /// <summary>
        /// ����ID
        /// </summary>
        [Column("AreaID")]
        public override int Id { get; set; }

        /// <summary>
        /// ����������
        /// </summary>
        public virtual int AreaCode { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public virtual string AreaName { get; set; }

        /// <summary>
        /// ����ID
        /// </summary>
        public virtual int AreaParentID { get; set; }

        /// <summary>
        /// ����Code
        /// </summary>
        public virtual string AreaParentCode { get; set; }
        /// <summary>
        /// ��ǰ����ID
        /// </summary>
        public virtual int AreaLevelID { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public virtual int AreaOrderID { get; set; }
    }
}

