using FitnessTracker.Application.CQRS.Exercises.Queries.GetExercises;
using FitnessTracker.Application.CQRS.Exercises.Queries.GetMuscleGroups;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FitnessTracker.Api.Controllers
{
    [Authorize]
    public class ExercisesController : BaseController
    {
        private readonly IMediator _mediator;

        public ExercisesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<ExerciseListModel>> GetAll()
        {
            var result = await _mediator.Send(new GetExercisesQuery());
            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult<ExerciseListModel>> GetMuscleGroups()
        {
            var result = await _mediator.Send(new GetMuscleGroupsQuery());
            return Ok(result);
        }
    }
}
