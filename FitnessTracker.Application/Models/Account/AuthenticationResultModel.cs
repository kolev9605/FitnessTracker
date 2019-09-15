using System;

namespace FitnessTracker.Application.Models.Account
{
    public class AuthenticationResultModel
    {
        public string Email { get; set; }

        public string UserId { get; set; }

        public string Token { get; set; }

        public DateTime ExpirationDate { get; set; }
    }
}
