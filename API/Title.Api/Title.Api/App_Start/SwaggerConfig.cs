using Swashbuckle.Application;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;

namespace Title.Api.App_Start
{
    public static class SwaggerConfig
    {
        /// <summary>
        /// Generating the Swager XML file
        /// </summary>
        static string XmlCommentsFilePath
        {
            get
            {
                var basePath = System.AppDomain.CurrentDomain.RelativeSearchPath;
                var fileName = typeof(SwaggerConfig).GetTypeInfo().Assembly.GetName().Name + ".xml";
                return Path.Combine(basePath, fileName);
            }
        }
        public static void Register(HttpConfiguration config)
        {
            config.EnableSwagger(c => {
                c.SingleApiVersion("v1", "title-swagger");
                c.PrettyPrint();
                //c.OperationFilter<SwaggerDefaultValues>();
                //c.IncludeXmlComments(XmlCommentsFilePath);
            }

            ).EnableSwaggerUi();
        }
    }

}