using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.Entities
{
	/// <summary>
    /// mic_Jurisdiction:实体类(角色栏目权限表)
	/// </summary>
	[Table("Mic_Jurisdiction")]
	public  class Mic_Jurisdiction:Entity
	{

		#region Model
        /// <summary>
        /// 主键id (角色栏目权限表)
        /// </summary>
        [Column("id")]
        public override int Id { get; set; }

        /// <summary>
        /// 角色权限栏目集合
        /// </summary>
        public string type_mode { get; set; }

        /// <summary>
        /// 角色role_id
        /// </summary>
        public int role_id { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string descirption { get; set; }
     
		#endregion Model

	}
}

