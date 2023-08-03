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
