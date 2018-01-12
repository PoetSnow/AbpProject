using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyProject.Web.Models.Mic_Admin;
using MyProject.Web.Helpers;
using System.Text;
using MyProject.Mic_Operation;
using MyProject.Mic_Type;

namespace MyProject.Web.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        //服务
        private readonly IMic_OperationAppService _mic_Operation;
        private readonly IMic_TypeAppService _mic_TypeAppservice;


        //栏目Html
        protected StringBuilder strHtml = new StringBuilder();
        protected string _DefaultUrl = "";
        public MainController(IMic_OperationAppService mic_Operation, IMic_TypeAppService mic_TypeAppservice)
        {
            _mic_Operation = mic_Operation;
            _mic_TypeAppservice = mic_TypeAppservice;
        }

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Left()
        {

            string typeid = Request.QueryString["typeid"];

            string htmlStr = LeftTypeList(typeid);
            ViewData["typeid"] = $"{htmlStr}";
            return View();
        }
        public ActionResult Right()
        {
            return View();
        }

        public ActionResult Top()
        {
            //返回到前端的html
            StringBuilder str = new StringBuilder();
            if (CheckOperation())
            {
                var typeList = _mic_TypeAppservice.typeList(0);
               //如果不是超级管理员。屏蔽系统开发栏目
                if (Session["UserName"].ToString()!="manage")
                {
                    typeList = typeList.Where(x => x.Id != 1).ToList();
                }
                int i = 0;
                foreach (var type in typeList)
                {

                    int itypeid = type.Id;
                    string itypename = type.type_name;
                    string iurlstr = type.description;
                    string idefaulturl = type.url;
                    iurlstr = (iurlstr == "" ? "javascript:;" : iurlstr);//window.right.href='{0}';window.left.href='{0}'; alert('adsfda');
               
                    switch (type.target)
                    {
                        case "1":
                            str.AppendFormat("<a href=\"{0}\" target=\"left\" onclick=\"javascript:OnClickA('{2}');\" {3}><b>{1}</b></a>\r\n", iurlstr, itypename, itypeid, (i == 0 ? "class=\"current\"" : ""));
                            str.AppendFormat("<a href=\"{0}\" target=\"right\" style=\"padding-left:15px; display:none;\" id=\"{2}\">{1}</a>\r\n", idefaulturl, itypename, itypeid);
                            break;
                        case "2":
                            str.AppendFormat("<a href=\"{0}\" target=\"_blank\" {3}><b>{1}</b></a>\r\n", idefaulturl, itypename, itypeid, (i == 0 ? "class=\"current\"" : ""));
                            break;
                        default:
                            str.AppendFormat("<a href=\"{0}\" target=\"left\" onclick=\"javascript:OnClickA('{2}');\" {3}><b>{1}</b></a>\r\n", iurlstr, itypename, itypeid, (i == 0 ? "class=\"current\"" : ""));
                            str.AppendFormat("<a href=\"{0}\" target=\"right\" style=\"padding-left:15px; display:none;\" id=\"{2}\">{1}</a>\r\n", idefaulturl, itypename, itypeid);
                            break;
                    }
                    i++;
                }
            }
            ViewData["UrlList"] = $"{str.ToString()}";

            return View(
                new UserInfo
                {
                    Id = CookieHtml.Id,
                    UserName = Session["UserName"].ToString()
                }
                );
        }

        public ActionResult Bottom()
        {
            return View();
        }

        public ActionResult AdminMain()
        {
            return View();
        }

        #region 获取左边栏目


        private string LeftTypeList(string typleId)
        {
            //var Id = CookieHtml.Id;//用户ID
            //var userName = CookieHtml.userName;//用户名
            var userName = Session["UserName"].ToString();
           

            switch (userName)
            {
                case "manage":  //开发管理员
                    if (CheckOperation())
                    {

                        GetProgramaData(0, "", 0, typleId);
                    }
                    break;
                case "admin":   //客户管理栏目
                    break;
                default:        //普通管理员
                    break;
            }

            return strHtml.ToString();
        }

        /// <summary>
        /// 判断网站后台是否关闭
        /// </summary>
        /// <returns></returns>
        private bool CheckOperation()
        {
            bool state = false;
            //获取mic_Operation的行数与信息
            var operation = _mic_Operation.GetOperationInfo();
            //网站后台打开状态
            if (operation.Count > 0 && operation.Status == "0")
            {
                state = true;
            }
            return state;
        }


        /// <summary>
        /// 递归获取子级栏目
        /// </summary>
        /// <param name="ParentID"></param>
        /// <param name="Where"></param>
        /// <param name="RecursiveCount"></param>
        /// <param name="typleId"></param>
        void GetProgramaData(int ParentID, string Where, int RecursiveCount, string typleId)
        {
            RecursiveCount = RecursiveCount + 1;
            //获取下级栏目
            var typeList = _mic_TypeAppservice.typeList(ParentID);
            //筛选符合当前typeID的数据
            if (ParentID==0)
            {
                typeList= typeList.Where(x => x.Id == Convert.ToInt32(typleId)).ToList();
            }
            
            foreach (var typeRow in typeList)
            {
                if (ParentID == 0)
                {
                    _DefaultUrl = typeRow.url.ToString();
                }
                var nextTypeList = _mic_TypeAppservice.typeList(typeRow.Id);
                int nextrow = nextTypeList.Count;
                string ispointer = " style='cursor:pointer; padding:0px 2px 2px 0px;' " + " onclick='showhideit(" + typeRow.Id.ToString() + ")'";
                if (nextrow > 0)
                {
                    ispointer = " style='cursor:pointer; padding:0px 2px 2px 0px;' " + " onclick='showhideit(" + typeRow.Id.ToString() + ")'";
                }
                else
                {
                    ispointer = " style='cursor:default;' ";
                }
                strHtml.Append("       <table id=\"tableItem" + typeRow.Id.ToString() + "\" name=\"tableItem\" cellspacing='0' cellpadding='0' border='0' " + ((ParentID != 0 && (typeRow.description=="null"?"": typeRow.description.ToString()) == _DefaultUrl) ? "class=\"treeItemCur\"" : "") + ">\r\n");
                strHtml.Append("           <tr align='center' onclick='showhideit(" + typeRow.Id.ToString() + ")'>\r\n");
                // 循环输出当前目录向右缩进数量
                for (int j = 1; j < RecursiveCount; j++)
                {
                    if (j == (RecursiveCount - 1))
                    {
                        if (typeList.IndexOf(typeRow) == (typeList.Count - 1))
                        {
                            // 判断是否有子级
                            if (nextrow > 0)
                            {
                                strHtml.Append("               <td><img src='/Images/left/bar1.gif'></td>\r\n");
                            }
                            else
                            {
                                strHtml.Append("               <td><img src='/Images/left/bar2.gif'></td>\r\n");
                            }
                        }
                        else
                        {
                            strHtml.Append("               <td><img src='/Images/left/bar1.gif'></td>\r\n");
                        }
                    }
                    else
                    {
                        strHtml.Append("               <td><img src='/Images/left/bar3.gif'></td>\r\n");
                    }
                }
                if (nextrow > 0 || ParentID == 0)
                {
                    strHtml.Append("               <td " + ispointer + ">&nbsp;<img src='/Images/left/no-sublist.gif'  name='openedfolderimage" + typeRow.Id.ToString() + "'><img src='/Images/left/topItem_exp.gif' style='display:none;'  name='closedfolderimage" + typeRow.Id.ToString() + "'></td>\r\n");
                    strHtml.Append("               <td style='cursor:pointer;'>&nbsp;" + typeRow.type_name.ToString() + " </td>\r\n");
                }
                else
                {
                    int iUrlTarget = Convert.ToInt32(typeRow.target);
                    switch (iUrlTarget)
                    {
                        case 1:
                            strHtml.Append("               <td " + ispointer + "><a href='" + typeRow.description.ToString() + "' target='right' name=\"" + typeRow.Id.ToString() + "\"><img src='/Images/Icons/treeicon09.gif' style='padding:0px;' name='NoChildrenLevel" + typeRow.Id.ToString() + "' width=\"20px\"></a></td>\r\n");
                            strHtml.Append("               <td style='cursor:pointer;'><a href='" + typeRow.description.ToString() + "' target='right' name=\"" + typeRow.Id.ToString() + "\">" + typeRow.type_name.ToString() + " &nbsp;&nbsp;</a></td>\r\n");
                            break;
                        case 2:
                            strHtml.Append("               <td " + ispointer + "><a href='" + typeRow.description.ToString() + "' target='_blank' name=\"" + typeRow.Id.ToString() + "\"><img src='/Images/Icons/treeicon09.gif' style='padding:0px;' name='NoChildrenLevel" + typeRow.Id.ToString() + "' width=\"20px\"></a></td>\r\n");
                            strHtml.Append("               <td style='cursor:pointer;'><a href='" + typeRow.description.ToString() + "' target='_blank' name=\"" + typeRow.Id.ToString() + "\">" + typeRow.type_name.ToString() + " &nbsp;&nbsp;</a></td>\r\n");
                            break;
                        default:
                            strHtml.Append("               <td " + ispointer + "><a href='" + typeRow.description.ToString() + "' target='right' name=\"" + typeRow.Id.ToString() + "\"><img src='/Images/Icons/treeicon09.gif' style='padding:0px;' name='NoChildrenLevel" + typeRow.Id.ToString() + "' width=\"20px\"></a></td>\r\n");
                            strHtml.Append("               <td style='cursor:pointer;'><a href='" + typeRow.description.ToString() + "' target='right' name=\"" + typeRow.Id.ToString() + "\">" + typeRow.type_name.ToString() + " &nbsp;&nbsp;</a></td>\r\n");
                            break;
                    }
                }
                strHtml.Append("           </tr>\r\n");
                strHtml.Append("       </table>\r\n");
                strHtml.Append("       <div class='blockshow' id='item" + typeRow.Id.ToString() + "'>\r\n");
                // 判断是否执行递归
                if (nextrow > 0)
                {
                    // 递归遍历当前目录下的子级
                    GetProgramaData(Convert.ToInt32(typeRow.Id), Where, RecursiveCount, typleId);
                }
                strHtml.Append("       </div>");

            }
        }

        #endregion
    }
}