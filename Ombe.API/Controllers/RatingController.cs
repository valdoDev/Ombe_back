using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Ombe.Business.Interfaces;

namespace Ombe.API.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class RatingController : MainController
    {
        public RatingController(INotifier notifier, ILogger<RatingController> logger) : base(notifier, logger)
        {
        }
    }
}
