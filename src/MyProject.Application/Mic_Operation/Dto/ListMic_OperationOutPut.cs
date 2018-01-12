using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Mic_Operation.Dto
{
    /// <summary>
    /// 返回数据列表。并统计行数
    /// </summary>
  public  class ListMic_OperationOutPut
    {
        /// <summary>
        /// 行数
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public string Status { get; set; }
    }
}
