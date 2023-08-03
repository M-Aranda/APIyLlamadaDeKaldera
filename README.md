1) Abrir proyecto de APIOkKaldera
2) A ese proyecto, agregarle el proyecto de LLamarAPIKaldera
3) Ejecutar ambos a la vez (requiere inicio multiple, click derecho sobre solucion->set start up projects->marcar ambos proyectos)
   *En caso de no encontrarse esta opción inmediatamente, click derecho sobre solucion->propiedades->common properties->startup project-> multiple startup projects->action-> start->apply->aceptar)*
4) Deberia abrirse una ventana de navegador por defecto, que tira error 403 (la API solo tiene un endpoint, que es para POST) y una ventana de consola, ésta última muestra la respuesta a la llamada

APIOkKaldera->Controllers->MessageController.cs (Click derecho sobre carpeta Controllers->add->controller->Web API->Web API 2 Controller-Empty)
//NuGets utilizados
/*
Microsoft.AspNet.WebApi
Microsoft.AspNet.WebApi.Client
Microsoft.AspNet.WebApi.Core
Microsoft.AspNet.WebApi.Host
Microsoft.CodeCom.Providers.DotNetCompilerPlatform
Newtonsoft.Json
*/

  [HttpPost]//Anotacion necesaria para tratar llamadas tipo POST

return Ok("Este es un mensaje de prueba");//con codigo 200 este es el contenido del mensaje



LlamarAPIKaldera->Program.cs

    private static string GetApiUrlFromConfiguration()//método para obtener URL de la API, el cual esta en el archivo App.config
    {
        return System.Configuration.ConfigurationManager.AppSettings["ApiUrl"];
    }


App.config es un archivo que tiene código XML dentro, pero se crea con click derecho sobre proyecto-> add-> application configuration file

Uso de System.Configuration y System.Net.Http



Hecho con Visual Sutdio 2022



