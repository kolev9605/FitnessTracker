using FitnessTracker.Application.AwsCQRS.Exercises.Queries.GetExercises;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FitnessTracker.Serverless.Controllers
{
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
    }
}
