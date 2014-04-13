using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace FormsAuthJSONPDemo2
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
			config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            GlobalConfiguration
                .Configuration
                .Formatters
                .Insert(0, new Auth.Web.WebApi.JsonpFormatter());
        }
    }
}
