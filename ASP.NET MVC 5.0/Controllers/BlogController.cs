using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC_5._0.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public string Index(int year, int month, int day)
        {
            return year + "年" + month + "月" + day + "日";
        }
    }
}