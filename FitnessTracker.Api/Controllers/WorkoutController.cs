using FitnessTracker.Application.Workouts.Commands.AddWorkout;
using FitnessTracker.Application.Workouts.Queries.GetWorkouts;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FitnessTracker.Api.Controllers
{
    [Authorize]
    public class WorkoutController : BaseController
    {
        private readonly IMediator _mediator;

        public WorkoutController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<WorkoutListModel>> GetAll()
        {
            var result = await _mediator.Send(new GetWorkoutsQuery());
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult> Add([FromBody]AddWorkoutCommand addWorkoutCommand)
        {
            await _mediator.Send(addWorkoutCommand);
            return NoContent();
        }
    }
}
