using Microsoft.AspNetCore.Mvc;
using static System.IO.File;

namespace meuprimeiroprojeto.Controllers;

[ApiController]
[Route("/")]
public class TestController : ControllerBase
{
   [HttpGet("oi")]
   public ActionResult OutroTest ()
   {
        return Content(
        ReadAllText("views/index.html"), "text/html");
   }

   [HttpGet("ola")]
   public ActionResult OutroOutroTest ()
   {
        return Content(
        ReadAllText("views/login.html"), "text/html");
   }

   [HttpGet]
   public string Test ()
   {
        return "Meu Backend está rodando";

    }

}


