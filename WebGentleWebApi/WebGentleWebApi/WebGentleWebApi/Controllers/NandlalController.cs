using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebGentleWebApi.Controllers
{
    [Route("api/nitish/{id}")]
    public class NandlalController : ApiController
    {
        public IHttpActionResult Get([FromUri]int id)
        {
            return Ok(1);
        }
    }
}
