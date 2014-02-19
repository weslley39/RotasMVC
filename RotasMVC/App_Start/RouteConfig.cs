using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace RotasMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Todas as Noticias",
                url: "noticias/",
                defaults: new { Controller = "Home", action = "TodasAsNoticias" }
                );
            routes.MapRoute(
                name: "Categoria Especifica",
                url: "noticias/{categoria}",
                defaults: new { Controller = "Home", action = "mostraCategoria" }
                );
            routes.MapRoute(
                name: "Mostra Noticia",
                url: "noticias/{categoria}/{titulo}-{noticiaid}",
                defaults: new { Controller = "Home", action = "MostraNoticia" }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );


        }
    }
}