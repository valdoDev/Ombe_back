using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Logging;
using Ombe.Business.Interfaces;
using Ombe.Business.Notifications;
using System.Linq;

namespace Ombe.API.Controllers
{
    [ApiController]
    public class MainController : ControllerBase
    {
        private readonly INotifier _notifier;
        protected readonly ILogger _logger;

        public MainController(INotifier notifier, ILogger logger)
        {
            _notifier = notifier;
            _logger = logger;
        }

        protected bool isValidOperator()
        {
            return !_notifier.hasNotification();
        }

        protected ActionResult CustomResponse(object result = null)
        {
            if (isValidOperator())
            {
                return Ok(new
                {
                    sucess = true,
                    data = result
                });
            }

            return BadRequest(new
            {
                sucess = false,
                errors = _notifier.getNotification().Select(n => n.Message)
            });
        }

        protected ActionResult CustomResponse(ModelStateDictionary modelState)
        {
            if (!modelState.IsValid) NotifierErrorModelInvalid(modelState);
            return CustomResponse();
        }

        protected void NotifierErrorModelInvalid(ModelStateDictionary modelState)
        {
            var errors = modelState.Values.SelectMany(e => e.Errors);

            foreach (var error in errors)
            {
                var errorMsg = error.Exception == null ? error.ErrorMessage : error.Exception.Message;
                ReportError(errorMsg);
            }
        }

        protected void ReportError(string message)
        {
            _notifier.Handle(new Notification(message));
        }

    }
}
