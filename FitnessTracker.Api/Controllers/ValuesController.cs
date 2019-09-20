using FitnessTracker.Application.Exercises.Queries.GetExercises;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FitnessTracker.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ValuesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET api/values
        [HttpGet]
        public async Task<ActionResult<ExerciseListModel>> Get()
        {
            var res = await _mediator.Send(new GetExercisesQuery());
            return res;
        }
    }
}
