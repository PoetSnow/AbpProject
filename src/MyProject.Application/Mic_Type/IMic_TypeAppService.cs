using Abp.Application.Services;
using MyProject.Mic_Type.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Mic_Type
{
    public interface IMic_TypeAppService : IApplicationService
    {
        List<typeList> typeList(int parent_id);
    }
}
