using AutoMapper;
using MyProject.IRepositories;
using MyProject.Mic_Type.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Mic_Type
{
    public class Mic_TypeAppService : MyProjectAppServiceBase, IMic_TypeAppService
    {
        private readonly IMic_TypeRepository _mic_TypeRepository;
        public Mic_TypeAppService(IMic_TypeRepository mic_TypeRepository)
        {
            _mic_TypeRepository = mic_TypeRepository;
        }

        /// <summary>
        /// 查询子级栏目
        /// </summary>
        /// <param name="parent_id"></param>
        /// <returns></returns>
        public List<typeListDto> typeList(int parent_id)
        {
            List<typeListDto> list = new List<typeListDto>();
            var table = _mic_TypeRepository.ChildColumnList(parent_id);
            foreach (var item in table)
            {
                list.Add(Mapper.Map<typeListDto>(item));
            }
            return list;
        }


        public  List<typeListDto> typeListAll(int parent_id)
        {
            List<typeListDto> list = new List<typeListDto>();
            var table = _mic_TypeRepository.ChildColumnListAll(parent_id);
            foreach (var item in table)
            {
                list.Add(Mapper.Map<typeListDto>(item));
            }
            return list;
        }

        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public mic_TypeAddOutPut AddType(typeListDto input)
        {
            mic_TypeAddOutPut outPut = new mic_TypeAddOutPut();
            MyProject.Entities.Mic_Type mic_Type = new Entities.Mic_Type
            {
                type_name = input.type_name,
                parent_id = input.parent_id,
                order_id = input.order_id,
                n_id = input.n_id,
                target = input.target,
                display = true,
                url = string.IsNullOrEmpty(input.url) ? "javascript:;" : input.url,
                previewURL = string.IsNullOrEmpty(input.previewURL) ? "" : input.previewURL
            };
            var id = _mic_TypeRepository.InsertAndGetId(mic_Type);
            if (id > 0)
            {


                MyProject.Entities.Mic_Type mic_Type1 = _mic_TypeRepository.FirstOrDefault(id);
                mic_Type1.description = "Left?typeid=" + id;

                _mic_TypeRepository.Update(mic_Type1);
                outPut.state = 1;
            }
            else
            {
                outPut.state = 0;
            }
            return outPut;
        }


        public ValidateTypeOutPut ValidateType(ValidateTypeInPut input)
        {
            ValidateTypeOutPut outPut = new ValidateTypeOutPut();
            outPut.state = 1;
            var list = _mic_TypeRepository.ValidateType(input.type_name, input.parent_id);
            if (list.Count() > 1)
            {
                //有一条存在的数据。则不能添加
                outPut.state = 0;
            }
            return outPut;
        }


        public typeListDto typeModel(int Id)
        {
            var typeModel = _mic_TypeRepository.FirstOrDefault(Id);

            var listDto = Mapper.Map<typeListDto>(typeModel);
            return listDto;
        }

        public DeleteTypeOutPut DeleteTypeList(DeleteTypeInPut inPut)
        {
            DeleteTypeOutPut outPut = new DeleteTypeOutPut();

            var count = _mic_TypeRepository.DeleteTypeList(inPut.IdList);
            if (count > 0)
            {
                //删除成功
                outPut.state = 1;
            }
            else
            {
                //删除失败
                outPut.state = 0;
            }
            return outPut;
        }

        public UpdateTypeStateOutPut UpdateTypeState(UpdateTypeStateInPut inPut)
        {
            UpdateTypeStateOutPut outPut = new UpdateTypeStateOutPut();
            outPut.state = 0;
            var model = _mic_TypeRepository.FirstOrDefault(inPut.Id);
            if (inPut.status=="0")
            {
                model.display = false;
            }
            else
            {
                model.display = true;
            }
            _mic_TypeRepository.Update(model);
            outPut.state = 1;
            return outPut;
        }
    }
}






































