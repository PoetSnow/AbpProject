using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.Entities
{
    /// <summary>
    /// mic_ColumnOperation:实体类(角色增删改以及分类数据操作权限表)
    /// </summary>
    [Table("Mic_ColumnOperation")]
    public  class Mic_ColumnOperation: Entity
    {

        #region Model


        /// <summary>
        /// 主键ID (角色增删改以及分类数据操作权限表)
        /// </summary>
        [Column("Id")]
        public override int Id { get; set; }
	
	
		/// <summary>
		/// 角色id
		/// </summary>
	
        public int role_Id { get; set; }
        /// <summary>
        /// 栏目type_id
        /// </summary>
        public int type_Id { get; set; }

        /// <summary>
        /// 是否允许增加操作
        /// </summary>
        public bool C_add { get; set; }

        /// <summary>
        /// 是否允许修改操作
        /// </summary>
        public bool C_update { get; set; }

        /// <summary>
        /// 是否允许删除操作
        /// </summary>
        public bool C_delete { get; set; }

        /// <summary>
        /// 操作数据类型(允许SQL语句)
        /// </summary>
        public string C_datatype { get; set; }
      
		#endregion Model

	}
}

