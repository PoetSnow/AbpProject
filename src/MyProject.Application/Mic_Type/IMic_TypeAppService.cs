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
        List<typeListDto> typeList(int parent_id);


        List<typeListDto> typeListAll(int parent_id);
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        mic_TypeAddOutPut AddType(typeListDto input);

        /// <summary>
        /// 验证同级栏目是否有重复的
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        ValidateTypeOutPut ValidateType(ValidateTypeInPut input);
    
        /// <summary>
        /// 根据主键ID查询数据
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        typeListDto typeModel(int Id);


        /// <summary>
        /// 根据ID集合删除数据
        /// </summary>
        /// <param name="inPut"></param>
        /// <returns></returns>
        DeleteTypeOutPut DeleteTypeList(DeleteTypeInPut inPut);

        UpdateTypeStateOutPut UpdateTypeState(UpdateTypeStateInPut inPut);
    }
}
