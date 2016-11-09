using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace MyPages
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // JSON objects uses pass-gone notation, so the first letter of every word is upper case.
            // however, javascript uses camel notation, the first letter of first word is lower case 
            // and the first letter of every word after should be upper case.
            
            var setting = config.Formatters.JsonFormatter.SerializerSettings;
            setting.ContractResolver = new CamelCasePropertyNamesContractResolver();
            setting.Formatting = Formatting.Indented;
            // above part is for camel notation casting

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                // in api, there is no 'action' compared to web route.
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
