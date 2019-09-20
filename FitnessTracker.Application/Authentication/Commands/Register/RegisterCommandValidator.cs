﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessTracker.Application.Authentication.Commands.Register
{
    public class RegisterCommandValidator : AbstractValidator<RegisterCommand>
    {
        public RegisterCommandValidator()
        {
            RuleFor(x => x.ConfirmPassword)
                .Equal(x => x.Password)
                .WithMessage("Confirm password and password must match");
        }
    }
}
