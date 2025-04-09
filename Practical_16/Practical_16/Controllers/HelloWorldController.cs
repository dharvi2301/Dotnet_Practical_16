using Microsoft.AspNetCore.Mvc;

namespace Practical_16.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController : ControllerBase
    {
        private readonly ILogger<HelloWorldController> _logger;

        public HelloWorldController(ILogger<HelloWorldController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        
        public IActionResult Get()
        {
            _logger.LogInformation("Controller - HelloWorld \n\tActionMetod - Get Method called");
            return Content("Hello World !!");
        }
    }

}

