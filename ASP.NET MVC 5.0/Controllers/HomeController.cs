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

        //无 Route 无法被访问
        public string Search()
        {
            return "hello";
        }

        [HttpGet]
        [ActionName("date")]//不起作用
        [Route("{year}/{month}/{day}")]
        public string GetDate(string year, string month, string day)
        {
            return year + "年" + month + "月" + day + "日";
        }

    }
}