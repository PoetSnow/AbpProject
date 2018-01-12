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
    }
}






































