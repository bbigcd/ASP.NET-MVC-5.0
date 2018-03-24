using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ASP.NET_MVC_5._0
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //映射应用程序的特性定义路由，Controller中需要为公开的api定义特性 [RouteAttributes]
            //routes.MapMvcAttributeRoutes();

            // 此为传统路由
            routes.MapRoute(
                name: "Default",//路由名称
                url: "{controller}/{action}/{id}",// 路由的URL模式构成由 控制器/操作方法/字段值 
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }// 默认的值，其中 id = UrlParameter.Optional 表示字段值为可选值
            );

            // 传统路由 字段约束
            routes.MapRoute(
                name: "blog",
                url: "blog/{year}/{month}/{day}",
                defaults: new { controller = "blog", action = "index" },
                constraints: new { year = @"\d{4}", month = @"\d{2}", day = @"\d{2}" }
                );
        }
    }
}
