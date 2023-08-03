using System.Web.Http;

//NuGets utilizados
/*
Microsoft.AspNet.WebApi
Microsoft.AspNet.WebApi.Client
Microsoft.AspNet.WebApi.Core
Microsoft.AspNet.WebApi.Host
Microsoft.CodeCom.Providers.DotNetCompilerPlatform
Newtonsoft.Json
*/

namespace APIOkKaldera.Controllers
{
    public class MessageController : ApiController//Click derecho sobre carpeta Controllers->add->controller->Web API->Web API 2 Controller-Empty
    {

        [HttpPost]//Anotacion necesaria para tratar llamadas tipo POST
        public IHttpActionResult Post()
        {
            return Ok("Este es un mensaje de prueba");//con codigo 200 este es el contenido del mensaje
        }

    }
}
