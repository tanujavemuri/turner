using Swashbuckle.Swagger.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Title.Api.Agent;
using Title.Api.DB;
using Title.Api.Models;

namespace Title.Api.Controllers
{
    [Route("api/title")]
    public class TitleController : ApiController
    {
        private readonly TitleAgent titleAgent;
        public TitleController()
        {
            titleAgent = new TitleAgent();
        }
        /// <summary>
        /// To get the title Infromation from DB
        /// </summary>
        /// <param name="TitleName">Input Title name</param>
        /// <returns></returns>

        [HttpGet]
        [Route("GetMedia/{TitleName}")]
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(TitleModel), Description = "Title response")]
        [SwaggerResponse(HttpStatusCode.InternalServerError, "Internal server error")]
        public IHttpActionResult GetTitleByName(string TitleName)
        {
            
            return Ok(titleAgent.GetTitleByname(TitleName));
        }

        [HttpGet]
        [Route("GetMedia/TitlesName/{TitleName}")]
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(List<TitleModel>), Description = "Title response")]
        [SwaggerResponse(HttpStatusCode.InternalServerError, "Internal server error")]
        public IHttpActionResult GetTitlesByName(string TitleName)
        {

            return Ok(titleAgent.GetTitlesByname(TitleName));
        }
    }
}
