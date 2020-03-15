using System;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyProject.Models;
using Serilog;

namespace MyProject.Controllers
{
    [ApiController]
    public class ErrorController : Controller
    {
        public string ExceptionMessage { get; private set; }


        [Route("/error-local-development")]
        public IActionResult ErrorLocalDevelopment([FromServices] IWebHostEnvironment webHostEnvironment)
        {
            if (webHostEnvironment.EnvironmentName != "Development")
            {
                throw new InvalidOperationException(
                    "This shouldn't be invoked in non-development environments.");
            }

            var context = HttpContext.Features.Get<IExceptionHandlerFeature>();

            return Problem(
                detail: context.Error.StackTrace,
                title: context.Error.Message);
        }


        [Route("/error")]
        public IActionResult Error()
        {
            var context = HttpContext.Features.Get<IExceptionHandlerFeature>();

            ErrorViewModel errorView = new ErrorViewModel();
            errorView.Message = context.Error.Message;
            errorView.StackTrace = context.Error.StackTrace;

            Log.Error(context.Error.StackTrace);

            return View(errorView);
        }
    }
}