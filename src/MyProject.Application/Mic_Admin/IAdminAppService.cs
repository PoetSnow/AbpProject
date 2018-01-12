using Abp.Application.Services;
using MyProject.Mic_Admin.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Mic_Admin
{
    public interface IAdminAppService: IApplicationService
    {
        Login_AdminOutPut Login(Login_AdminInput input);
    }
}
