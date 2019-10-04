using FitnessTracker.Application.Workouts.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessTracker.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class WorkoutController : Controller
    {
        private readonly IMediator _mediator;

        public WorkoutController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<ActionResult<WorkoutListModel>> GetAll()
        {
            var result = await _mediator.Send(new GetWorkoutsQuery());
            return Ok(result);
        }
    }
}
