using System.Web.Mvc;
using System.Web.Routing;

namespace MyPages
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // dynamic route that can be defined in controller class before method
            routes.MapMvcAttributeRoutes();

            // This is a customized route, which sort Movies by release Date, be aware, this part is fragile after update method name in corresponding controller.
            //routes.MapRoute(
            //    "MoviesByReleaseDate",
            //    "movies/released/{year}/{month}",
            //    new {controller="movies",action="ByReleaseDate"},
            //    // if we only accept 2015 or 2016, we can use regular expression @"\d{2015|2016}. if we dont use @, this should be wrote in "\\d{2015|2016}"
            //    new { year=@"\d{4}",month=@"\d{2}"});


            routes.MapRoute(
                "Default",
                "{controller}/{action}/{id}",
                new {controller = "Home", action = "Index", id = UrlParameter.Optional}
            );
        }
    }
}