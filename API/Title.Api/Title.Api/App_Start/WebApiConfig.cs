using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Title.Api.App_Start;

namespace Title.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

         

            #region API Swagger configuration
            SwaggerConfig.Register(config);
            #endregion
        }
    }
}
