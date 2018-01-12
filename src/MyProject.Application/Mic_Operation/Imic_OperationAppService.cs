using Abp.Application.Services;
using MyProject.Mic_Operation.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Mic_Operation
{
    public interface IMic_OperationAppService : IApplicationService
    {
        ListMic_OperationOutPut GetOperationInfo();
    }
}
