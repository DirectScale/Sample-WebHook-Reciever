using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace WebHookRecieverSample.Controllers
{
    [Route("api/[controller]")]
    public class WebHooksController : Controller
    {
        [HttpPost]
        [Route("EnrollmentEvent")]
        public void ReceiveEnrollmentEvent([FromBody]JObject evt)
        {
            // Process the enrollment event.
        }

        [HttpPost]
        [Route("OrderEvent")]
        public void ReceiveOrderEvent([FromBody]JObject evt)
        {
            // Process the order event.
        }

        // Additional hooks can be added here.
        // Be sure to exactly mimic the above pattern to get swagger to
        // display it correctly in the UI.
    }
}
