using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace WebHookReceiverSample.Controllers
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

        [HttpPost]
        [Route("CreateSubscriptionEvent")]
        public void ReceiveCreateSubscriptionEvent([FromBody] JObject evt)
        {
            // Process the create subscription event.
        }

        [HttpPost]
        [Route("UpdateSubscriptionEvent")]
        public void ReceiveUpdateSubscriptionEvent([FromBody] JObject evt)
        {
            // Process the update subscription event.
        }

        [HttpPost]
        [Route("CreateAssociateEvent")]
        public void ReceiveCreateAssociateEvent([FromBody] JObject evt)
        {
            // Process the create associate event.
        }

        [HttpPost]
        [Route("UpdateAssociateEvent")]
        public void ReceiveUpdateAssociateEvent([FromBody] JObject evt)
        {
            // Process the update associate event.
        }

        // Additional hooks can be added here.
        // Be sure to exactly mimic the above pattern to get swagger to
        // display it correctly in the UI.
    }
}
