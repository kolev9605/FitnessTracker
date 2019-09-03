using FitnessTracker.Application.Interfaces;
using FitnessTracker.Persistance;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessTracker.Web.Controllers
{
    [AllowAnonymous]
    [Route("api/test")]
    public class TestController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public TestController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        [Route("val")]
        public async Task<IActionResult> Values()
        {

            return new OkObjectResult(1);
        }

    }
}
