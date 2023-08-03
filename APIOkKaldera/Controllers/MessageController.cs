using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIOkKaldera.Controllers
{
    public class MessageController : ApiController
    {

        [HttpPost]
        public IHttpActionResult Post()
        {
            return Ok("Este es un mensaje de prueba");
        }

    }
}
