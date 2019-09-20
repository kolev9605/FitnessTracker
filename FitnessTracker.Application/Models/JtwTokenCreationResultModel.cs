using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessTracker.Application.Models
{
    public class JtwTokenCreationResultModel
    {
        public string Email { get; set; }

        public string UserId { get; set; }

        public string Token { get; set; }

        public DateTime ExpirationDate { get; set; }
    }
}
