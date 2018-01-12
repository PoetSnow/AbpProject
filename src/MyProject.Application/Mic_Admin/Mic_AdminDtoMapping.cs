using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MyProject.Entities;
using MyProject.Mic_Admin.Dto;

namespace MyProject.Mic_Admin
{
    public class Mic_AdminDtoMapping : IDtoMapping
    {
        public void CreateMapping(IMapperConfigurationExpression mapperConfig)
        {
            mapperConfig.CreateMap<MyProject.Entities.Mic_Admin, UserInfoList>();
            mapperConfig.CreateMap<MyProject.Entities.Mic_Admin, AdminDto>();
        }
    }
}
