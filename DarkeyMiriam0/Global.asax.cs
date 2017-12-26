using DarkeyMiriam0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace DarkeyMiriam0
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public object JsonConfig { get; private set; }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            //GlobalConfiguration.Configure(JsonConfig.Register);
            //var sr = GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings;
            //sr.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.None;
            //sr.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            ////for desing time only. make sure that the json object is json type instead of xml type, in chrome.
            //GlobalConfiguration.Configuration.Formatters.JsonFormatter.MediaTypeMappings.Add(new QueryStringMapping("type", "json", new MediaTypeHeaderValue("application/json"))); 
        }
        //protected void Application_Start()
        //{
        //    GlobalConfiguration.Configure(JsonConfig.Register);
        //}


    }
}
