using MyProject.IRepositories;
using MyProject.Mic_Operation.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProject.Entities;
namespace MyProject.Mic_Operation
{
    public class Mic_OperationAppService : MyProjectAppServiceBase, IMic_OperationAppService
    {
        private readonly IMic_OperationRepository _mic_Operation;
        public Mic_OperationAppService(IMic_OperationRepository mic_Operation)
        {
            _mic_Operation = mic_Operation;
        }
        /// <summary>
        /// 统计行数
        /// </summary>
        /// <returns></returns>
        public ListMic_OperationOutPut GetOperationInfo()
        {
            var queryable = _mic_Operation.ListOperation();
            ListMic_OperationOutPut outPut = new ListMic_OperationOutPut();
            outPut.Count = queryable.Count();
            outPut.Status = queryable.FirstOrDefault().Status.ToString();
            return outPut;

        }
    }
}
