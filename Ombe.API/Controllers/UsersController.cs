using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Ombe.Business.Interfaces;

namespace Ombe.API.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class UsersController : MainController
    {
        public UsersController(INotifier notifier, ILogger<UsersController> logger) : base(notifier, logger)
        {


        }

        [HttpGet]
        public ActionResult<string> Get()
        {
            _logger.LogInformation("Request Method get");
            return Ok("");
        }
    }
}
