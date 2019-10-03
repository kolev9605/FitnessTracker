﻿using FitnessTracker.Application.Authentication.Commands.Login;
using FitnessTracker.Application.Authentication.Commands.Register;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FitnessTracker.Api.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    public class AccountController : Controller
    {
        private readonly IMediator _mediator;

        public AccountController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("Login")]
        public async Task<ActionResult<LoginResultModel>> Login([FromBody] LoginCommand model)
        {
            var result = await _mediator.Send(model);

            return Ok(result);
        }

        [HttpPost]
        [Route("Register")]
        public async Task<ActionResult<RegisterResultModel>> Register([FromBody] RegisterCommand model)
        {
            var result = await _mediator.Send(model);

            return Ok(result);
        }
    }
}