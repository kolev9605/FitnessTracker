﻿using System;

namespace FitnessTracker.Application.CQRS.Cognito.Commands.Register
{
    public class RegisterResultModel
    {
        public string Email { get; set; }

        public string UserId { get; set; }

        public string Token { get; set; }

        public DateTime ExpirationDate { get; set; }
    }
}