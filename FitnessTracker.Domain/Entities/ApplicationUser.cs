﻿using Microsoft.AspNetCore.Identity;

namespace FitnessTracker.Domain.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
