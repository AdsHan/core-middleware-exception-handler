using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace MEH.Teste.API.Controllers
{

    [ApiController]
    public class ErrorController : ControllerBase
    {

        [Route("/error")]
        [ApiExplorerSettings(IgnoreApi = true)]
        public IActionResult GetError([FromServices] IWebHostEnvironment env)
        {

            if (env.EnvironmentName != "Development") return Problem();

            var exception = HttpContext.Features.Get<IExceptionHandlerFeature>().Error;

            return Problem(
                detail: exception.StackTrace,
                title: exception.Message,
                type: exception.GetType().Name);

        }

    }
}
