using Microsoft.AspNetCore.Mvc;

namespace Rock3t.Web.Api.Test.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Test : ControllerBase
    {
        private readonly ILogger<Test> _logger;

        public Test(ILogger<Test> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetHelloWorld")]
        public string Get()
        {
            return "Hello World!";
        }
    }
}