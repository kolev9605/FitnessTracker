using System.ComponentModel.DataAnnotations;

namespace FitnessTracker.Application.Models.Account
{
    public class LoginModel
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
