using MyProject.Mic_Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;
using MyProject.Mic_Type.Dto;
using Abp.Web.Security.AntiForgery;

namespace MyProject.Web.Controllers
{
    public class MenuController : Controller
    {
        private readonly IMic_TypeAppService _mic_TypeAppservice;

        StringBuilder str = new StringBuilder();
        int _Number = 0;
        public MenuController(IMic_TypeAppService mic_TypeAppservice)
        {
            _mic_TypeAppservice = mic_TypeAppservice;
        }
        // GET: Menu
        public ActionResult menu_status()
        {
            GetProgramaData(0, "", 0);
            ViewData["htmlStr"] = $"{str.ToString()}";
            return View();
        }

        public ActionResult menu_Add()
        {
            return View();
        }


        /// <summary>
        /// 添加栏目
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [DisableAbpAntiForgeryTokenValidation]
        public string AddType(typeListDto input)
        {
            var outPut = _mic_TypeAppservice.AddType(input);
            return outPut.state.ToString();
        }

        [DisableAbpAntiForgeryTokenValidation]
        public int ValidateType(ValidateTypeInput input)
        {
            var outPut = _mic_TypeAppservice.ValidateType(input);
            return outPut.state;
        }


        #region 栏目列表
        void GetProgramaData(int ParentID, string Where, int RecursiveCount)
        {
            RecursiveCount = RecursiveCount + 1;

            var typeList = _mic_TypeAppservice.typeList(ParentID);
            for (int i = 0; i < typeList.Count; i++)
            {
                _Number++;
                // 距离左边的距离
                string paddingleft = "　|- ";
                // 判断是否拥有子级

                var typeListSon = _mic_TypeAppservice.typeList(typeList[i].Id);
                bool isSonLevel = (typeListSon.Count > 0 ? true : false);
                // 循环输出但前目录向右缩进数量
                for (int j = 0; j < RecursiveCount - 1; j++)
                {
                    paddingleft = paddingleft + "　　|- ";
                }
                int typeid = typeList[i].Id;
                str.Append("<tr style=\"border-color:#DDDDDD;border-width:1px;border-style:solid;height:30px;\" " + (_Number % 2 == 0 ? " Class=\"odd\"" : "") + ">\r\n");
                str.Append("    <td align=\"center\"><input type=\"checkbox\" name=\"prolid\" value=\"" + typeid + "\" /></td>\r\n");
                str.Append("    <td align=\"center\" id=\"tdDistlay" + typeid + "\">" + (Convert.ToBoolean(typeList[i].display) == false ? "<a href=\"javascript:ModifyColumnDisplayAttribute('" + typeid + "', '1');\" style=\"color:Red;\" title=\"点击启用\">禁用</a>" : "<a href=\"javascript:ModifyColumnDisplayAttribute('" + typeid + "', '0');\" style=\"color: #555555;\" title=\"点击禁用\">启用</a>") + "</td>\r\n");
                str.Append("    <td align=\"center\" style=\"text-align:left\">");
                if (ParentID == 0)
                {
                    str.Append(paddingleft + "<strong><a href=\"javascript:menu_update1(" + typeid + ");\" style=\"color: #555555;\">" + typeList[i].type_name + "</a></strong>");
                }
                else
                {
                    str.Append(paddingleft + "<a href=\"javascript:menu_update1(" + typeid + ");\" style=\"color: #555555;\">" + typeList[i].type_name + "</a>");
                }
                str.Append("    </td>\r\n");
                // 链接地址
                str.Append("    <td align=\"left\">\r\n");
                string description = typeList[i].description;
                string previewURL = typeList[i].previewURL;
                string defaulturl = typeList[i].url;
                if (ParentID == 0)
                {
                    str.Append("        <span id=\"spanContent" + typeid + "\" style=\"float:left; padding-left:12px; display:block;\">" + description + " (默认加载链接：" + defaulturl + ")</span>\r\n");
                    str.Append("        <span id=\"spanUpdateContent" + typeid + "\" style=\"float:left; padding-left:12px; display:none; width:80%;\"><input id=\"TextUpdateContent" + typeid + "\" name=\"TextUpdateContent" + typeid + "\" type=\"text\" style=\"width:80%;\" value=\"" + description + "\" class='inputtext' /></span>\r\n");

                }
                else
                {
                    str.Append("        <span id=\"spanContent" + typeid + "\" style=\"float:left; padding-left:12px; display:block;\">" + description + (previewURL == "" ? "" : " (预览地址：" + previewURL + ")") + "</span>\r\n");
                    str.Append("        <span id=\"spanUpdateContent" + typeid + "\" style=\"float:left; padding-left:12px; display:none; width:80%;\"><input id=\"TextUpdateContent" + typeid + "\" name=\"TextUpdateContent" + typeid + "\" type=\"text\" style=\"width:80%;\" value=\"" + description + "\" class='inputtext' /></span>\r\n");
                }
                str.Append("    </td>\r\n");
                str.Append("</tr>\r\n");
                if (isSonLevel)
                {
                    GetProgramaData(typeid, Where, RecursiveCount);
                }
            }
        }
        #endregion
    }
}