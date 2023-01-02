using Microsoft.AspNetCore.Mvc;
using Ombe.Business.Interfaces;

namespace Ombe.API.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class FavoritesController : MainController
    {
        public FavoritesController(INotifier notifier) : base(notifier)
        {
        }
    }
}
