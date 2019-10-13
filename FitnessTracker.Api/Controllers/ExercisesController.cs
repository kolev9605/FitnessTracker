using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitnessTracker.Application.Exercises.Queries.GetExercises;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

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
    }
}
