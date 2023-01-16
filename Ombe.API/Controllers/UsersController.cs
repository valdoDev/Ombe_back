using Microsoft.AspNetCore.Mvc;
using Ombe.Business.Interfaces;

namespace Ombe.API.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class UsersController : MainController
    {
        public UsersController(INotifier notifier) : base(notifier)
        {


        }

        [HttpGet]
        public ActionResult<string> Get()
        {
            return Ok("");
        }
    }
}
