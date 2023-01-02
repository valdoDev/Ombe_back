using Microsoft.AspNetCore.Mvc;
using Ombe.Business.Interfaces;

namespace Ombe.API.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class InviteController : MainController
    {
        public InviteController(INotifier notifier) : base(notifier)
        {
        }
    }
}
