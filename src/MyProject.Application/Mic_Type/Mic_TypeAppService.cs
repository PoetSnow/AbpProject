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
        public List<typeList> typeList(int parent_id)
        {
            List<typeList> list = new List<typeList>();
            var table = _mic_TypeRepository.ChildColumnList(parent_id);
            foreach (var item in table)
            {
                list.Add(Mapper.Map<typeList>(item));
            }
            return list;
        }

        public mic_TypeAddOutPut AddType(typeList input)
        {
            mic_TypeAddOutPut outPut = new mic_TypeAddOutPut();
            MyProject.Entities.Mic_Type mic_Type = new Entities.Mic_Type
            {
                type_name = input.type_name,
                parent_id = input.parent_id,
                order_id = input.order_id,
                n_id = input.n_id,
                url = input.url,
                description = input.description,
                previewURL = input.previewURL,
                target = input.target,
                display = input.display
            };
            var id = _mic_TypeRepository.InsertAndGetId(mic_Type);
            if (id > 0)
            {
                outPut.state = id;
            }
            else
            {
                outPut.state = 0;
            }
            return outPut;
        }
    }
}






































