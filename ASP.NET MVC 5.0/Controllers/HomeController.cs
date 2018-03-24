using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC_5._0.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [Route("home/index")]
        [Route("home")]
        [Route("php")]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //-------------------------------
        //无 Route 将无法被访问
        //重载的接口，需要对路由的参数进行约束，才能匹配正确  在传统路由模式下，二者无法正确匹配
        [Route("home/search/{id:int}")]
        public string Search(int id)
        {
            return id.GetType().ToString();
        }

        //string 类型无须指定
        [Route("home/search/{id}")]
        public string Search(string id)
        {
            return id.GetType().ToString();
        }
        //-------------------------------

        [HttpGet]
        [ActionName("date")]//不起作用
        [Route("{year:int}/{month:int}/{day:int}")]
        public string GetDate(string year, string month, string day)
        {
            return year + "年" + month + "月" + day + "日";
        }

    }
}