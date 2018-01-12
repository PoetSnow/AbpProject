using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyProject.Web.Helpers
{
    public static class CookieHtml
    {
        public static int Id = 0;

        public static string userName = "";
        static  CookieHtml()
        {
            HttpCookie cookie = HttpContext.Current.Request.Cookies["userId"];// 读取cookieID
            HttpCookie cookie1 = HttpContext.Current.Request.Cookies["userName"];//用户名


            if (cookie != null)
            {
                Id = int.Parse(cookie.Value);
            }
            if (cookie1 != null)
            {
                userName = cookie1.Value;
            }
        }
    }
}