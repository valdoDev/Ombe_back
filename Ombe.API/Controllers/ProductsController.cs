using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Ombe.Business.Interfaces;

namespace Ombe.API.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class ProductsController : MainController
    {
        public ProductsController(INotifier notifier, ILogger<ProductsController> logger) : base(notifier, logger)
        {
        }
    }
}
