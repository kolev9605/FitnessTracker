using Microsoft.AspNetCore.Mvc;

namespace FitnessTracker.Serverless.Controllers
{
    public class TestController : BaseController
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok("I work");
        }
    }
}
