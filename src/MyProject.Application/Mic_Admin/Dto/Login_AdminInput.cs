using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Mic_Admin.Dto
{
    public class Login_AdminInput
    {
        
        /// <summary>
        /// 用户名
        /// </summary>
        public string userName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string passWord { get; set; }

        /// <summary>
        /// 验证码
        /// </summary>
        public string verifyCode { get; set; }
    }
}
