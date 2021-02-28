using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace TestAPI
{
    [CustomActionFilter]
    public class RequestsController : ApiController
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new[] { "foo", "bar" };
        }

        [HttpGet]
        [Route("api/mypath/{id}/something")]
        public IHttpActionResult CheckAttributeRoute(long id)
        {
            return Ok(id);
        }
    }
}