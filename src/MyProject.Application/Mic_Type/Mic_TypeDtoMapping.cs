using Abp.Collections;
using AutoMapper;
using MyProject.Mic_Type.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Mic_Type
{
    public class Mic_TypeDtoMapping: IDtoMapping
    {
        public void CreateMapping(IMapperConfigurationExpression mapperConfig)
        {
            mapperConfig.CreateMap<MyProject.Entities.Mic_Type, typeListDto>();
            
        }
    }
}
