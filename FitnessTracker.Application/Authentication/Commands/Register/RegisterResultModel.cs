using System;

namespace FitnessTracker.Application.Authentication.Commands.Register
{
    public class RegisterResultModel
    {
        public string Email { get; set; }

        public string UserId { get; set; }

        public string Token { get; set; }

        public DateTime ExpirationDate { get; set; }
    }
}
