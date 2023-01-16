using Microsoft.AspNetCore.Mvc;

namespace Ombe.API.Controllers
{

    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class AccountsController : ControllerBase
    {
    }
}
