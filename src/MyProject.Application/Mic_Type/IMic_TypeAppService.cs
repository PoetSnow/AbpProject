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
        /// <summary>
        /// 获取子级栏目
        /// </summary>
        /// <param name="parent_id"></param>
        /// <returns></returns>
        List<typeList> typeList(int parent_id);

        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        mic_TypeAddOutPut AddType(typeList input);

      //  ValidateTypeOutPut ValidateType()
    }
}
