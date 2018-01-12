using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.Entities
{
	/// <summary>
    /// mic_Jurisdiction:ʵ����(��ɫ��ĿȨ�ޱ�)
	/// </summary>
	[Table("Mic_Jurisdiction")]
	public  class Mic_Jurisdiction:Entity
	{

		#region Model
        /// <summary>
        /// ����id (��ɫ��ĿȨ�ޱ�)
        /// </summary>
        [Column("id")]
        public override int Id { get; set; }

        /// <summary>
        /// ��ɫȨ����Ŀ����
        /// </summary>
        public string type_mode { get; set; }

        /// <summary>
        /// ��ɫrole_id
        /// </summary>
        public int role_id { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public string descirption { get; set; }
     
		#endregion Model

	}
}

