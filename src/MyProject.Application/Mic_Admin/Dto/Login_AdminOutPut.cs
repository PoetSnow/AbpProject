using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Mic_Admin.Dto
{
    public class Login_AdminOutPut
    {
        /// <summary>
        /// 状态 0：登录失败
        /// </summary>
        public int state { get; set; }

        public UserInfoList userInfo;
    }
}
