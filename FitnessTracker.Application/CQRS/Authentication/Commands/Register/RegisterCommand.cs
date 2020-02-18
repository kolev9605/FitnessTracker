using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessTracker.Application.CQRS.Authentication.Commands.Register
{
    public class RegisterCommand : IRequest<RegisterResultModel>
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
