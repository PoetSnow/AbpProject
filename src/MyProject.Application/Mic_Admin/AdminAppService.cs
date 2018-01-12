using AutoMapper;
using MyProject.IRepositories;
using MyProject.Mic_Admin.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Mic_Admin
{
    public class AdminAppService: MyProjectAppServiceBase,IAdminAppService
    {

        private readonly IMic_AdminRepository _adminRepository;
        public AdminAppService(IMic_AdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }
        public Login_AdminOutPut Login(Login_AdminInput input)
        {
            var user = _adminRepository.Login(input.userName, input.passWord);
            Login_AdminOutPut outPut = new Login_AdminOutPut();
            if (user.Any())
            {
                outPut.state = 1;
                outPut.userInfo = Mapper.Map<UserInfoList>(user.FirstOrDefault());
            }
            else
            {
                outPut.state = 0;
                outPut.userInfo = null;
            }
            return outPut;
        }
    }
}
