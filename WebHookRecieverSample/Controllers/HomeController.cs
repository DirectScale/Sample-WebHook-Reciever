using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.SwaggerUI;

namespace WebHookReceiverSample.Controllers
{ 
    [Route("/")]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {
            return Redirect("/swagger");
        }
    }
}