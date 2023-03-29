using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ProyectoWeb
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
             name: "Seguridad",
             url: "Login/Seguridad",
             defaults: new { controller = "Login", action = "Seguridad", id = UrlParameter.Optional }
         );
            routes.MapRoute(
             name: "Gestion",
             url: "Login/Gestion",
             defaults: new { controller = "Login", action = "Gestion", id = UrlParameter.Optional }
         );
            routes.MapRoute(
             name: "Habilidades",
             url: "Login/Habilidades",
             defaults: new { controller = "Login", action = "Habilidades", id = UrlParameter.Optional }
         );

            routes.MapRoute(
              name: "Sesion",
              url: "Login/Sesion",
              defaults: new { controller = "Login", action = "Sesion", id = UrlParameter.Optional }
          );

            routes.MapRoute(
              name: "Nosotros",
              url: "Login/Nosotros",
              defaults: new { controller = "Login", action = "Nosotros", id = UrlParameter.Optional }
          );
            routes.MapRoute(
             name: "Programas",
             url: "Login/Programas",
             defaults: new { controller = "Login", action = "Programas", id = UrlParameter.Optional }
         );
            routes.MapRoute(
             name: "Convenios",
             url: "Login/Convenios",
             defaults: new { controller = "Login", action = "Convenios", id = UrlParameter.Optional }
         );
            routes.MapRoute(
          name: "Contactanos",
          url: "Login/Contactanos",
          defaults: new { controller = "Login", action = "Contactanos", id = UrlParameter.Optional }
      );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Login", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
