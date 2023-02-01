using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Ombe.Business.Interfaces;

namespace Ombe.API.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class UsersController : MainController
    {
        private readonly IUserRepository _userRepository;
        private readonly IProductRepository _productRepository;

        public UsersController(INotifier notifier, 
                               ILogger<UsersController> logger, 
                               IUserRepository userRepository, 
                               IProductRepository productRepository) : base(notifier, logger)
        {
            _userRepository = userRepository;
            _productRepository = productRepository;
        }

        [HttpGet]
        public ActionResult<string> Get()
        {
            //var da = new Ombe.Flow.Product.Create(_notifier, _userRepository, _productRepository).step1_ValidantionUser(System.Guid.NewGuid());

            _logger.LogInformation("Request Method get");
            return Ok("");
        }
    }
}
