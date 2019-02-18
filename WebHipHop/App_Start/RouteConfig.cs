using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebHipHop
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
           name: "artistdetail",
           url: "nghe-si-chi-tiet",
           defaults: new { controller = "Home", action = "ArtistDetail" },
          namespaces: new[] { "WebHipHop.Main.Controllers" }
       ).DataTokens.Add("Area", "Main");
            routes.MapRoute(
            name: "artist",
            url: "nghe-si",
            defaults: new { controller = "Home", action = "Artists" },
           namespaces: new[] { "WebHipHop.Main.Controllers" }
        ).DataTokens.Add("Area", "Main");
            routes.MapRoute(
              name: "albums",
              url: "album",
              defaults: new { controller = "Home", action = "Mixtapes" },
             namespaces: new[] { "WebHipHop.Main.Controllers" }
          ).DataTokens.Add("Area", "Main");
            routes.MapRoute(
           name: "videodetail",
           url: "video-chi-tiet",
           defaults: new { controller = "Home", action = "VideoDetail" },
          namespaces: new[] { "WebHipHop.Main.Controllers" }
       ).DataTokens.Add("Area", "Main");
            routes.MapRoute(
               name: "videos",
               url: "video",
               defaults: new { controller = "Home", action = "Videos" },
              namespaces: new[] { "WebHipHop.Main.Controllers" }
           ).DataTokens.Add("Area", "Main");
            routes.MapRoute(
                 name: "songs",
                 url: "bai-hat",
                 defaults: new { controller = "Home", action = "Songs" },
                namespaces: new[] { "WebHipHop.Main.Controllers" }
             ).DataTokens.Add("Area", "Main");
            routes.MapRoute(
               name: "top100",
               url: "top-100",
               defaults: new { controller = "Home", action = "Top100" },
              namespaces: new[] { "WebHipHop.Main.Controllers" }
           ).DataTokens.Add("Area", "Main");
            routes.MapRoute(
                name: "tintuc",
                url: "tin-tuc",
                defaults: new { controller = "Home", action = "News" },
               namespaces: new[] { "WebHipHop.Main.Controllers" }
            ).DataTokens.Add("Area", "Main");
                    routes.MapRoute(
                    name: "trangchu",
                    url: "trang-chu",
                    defaults: new { controller = "Home", action = "Index" },
                   namespaces: new[] { "WebHipHop.Main.Controllers" }
                ).DataTokens.Add("Area", "Main");
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
              namespaces: new[] { "WebHipHop.Main.Controllers" }
            ).DataTokens.Add("Area", "Main");
        }
    }
}
