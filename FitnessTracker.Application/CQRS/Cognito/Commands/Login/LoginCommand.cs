using MediatR;

namespace FitnessTracker.Application.CQRS.Cognito.Commands.Login
{
    public class LoginCommand : IRequest<LoginResultModel>
    {
        public string Email { get; set; }

        public string Password { get; set; }
    }
}
