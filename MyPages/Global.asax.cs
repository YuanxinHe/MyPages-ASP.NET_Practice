using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AutoMapper;
using MyPages.App_Start;

namespace MyPages
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // use for MappingProfile configuration
            Mapper.Initialize(c=>c.AddProfile<MappingProfile>());
            // use for Web api configuration
            GlobalConfiguration.Configure(WebApiConfig.Register);
            // default configuration
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            
        }
    }
}
