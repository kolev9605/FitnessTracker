using FitnessTracker.Application.CQRS.Exercises.Queries.GetExercises;
using FitnessTracker.Application.CQRS.Exercises.Queries.GetMuscleGroups;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FitnessTracker.Api.Controllers
{
    [ApiController]
    public class ValuesController : BaseController
    {
        private readonly IMediator _mediator;

        public ValuesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        [HttpGet]
        public async Task<ActionResult<MuscleGroupsListModel>> Index()
        {
            var res = await _mediator.Send(new GetMuscleGroupsQuery());
            return res;
        }
    }
}
