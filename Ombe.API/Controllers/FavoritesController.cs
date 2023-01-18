using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Ombe.Business.Interfaces;

namespace Ombe.API.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class FavoritesController : MainController
    {
        public FavoritesController(INotifier notifier, ILogger<FavoritesController> logger) : base(notifier, logger)
        {
        }
    }
}
