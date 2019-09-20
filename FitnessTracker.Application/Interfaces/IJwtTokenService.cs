using FitnessTracker.Application.Models;
using FitnessTracker.Domain.Entities;

namespace FitnessTracker.Application.Interfaces
{
    public interface IJwtTokenService
    {
        JtwTokenCreationResultModel GenerateJwtToken(string email, ApplicationUser user);
    }
}
