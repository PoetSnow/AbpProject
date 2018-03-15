using MyProject.Mic_Type;
using MyProject.Mic_Type.Dto;
using MyProject.Web.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyProject.Web.Controllers
{
    /// <summary>
    /// 缓存测试
    /// </summary>
    public class TestController : Controller
    {

        private readonly IMic_TypeAppService _mic_TypeAppservice;


        public TestController(IMic_TypeAppService mic_TypeAppService)
        {
            _mic_TypeAppservice = mic_TypeAppService;
        }
        // GET: Test
        public ActionResult Index()
        {

            var s = FindCompanys(1);
            return View();
        }
        public IEnumerable<typeListDto> FindCompanys(int typeId)
        {
            var cache = CacheHelp.GetCache("commonData_Company");//先读取  
            if (cache == null)//如果没有该缓存  
            {
                var queryCompany = _mic_TypeAppservice.typeListAll(typeId);//从数据库取出  
                var enumerable = queryCompany.ToList();
                CacheHelp.SetCache("commonData_Company", enumerable);//添加缓存  
                return enumerable;
            }
            var result = (List<typeListDto>)cache;//有就直接返回该缓存  
            return result;
        }
    }
}