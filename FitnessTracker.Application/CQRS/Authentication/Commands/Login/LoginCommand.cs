using MediatR;

namespace FitnessTracker.Application.CQRS.Authentication.Commands.Login
{
    public class LoginCommand : IRequest<LoginResultModel>
    {
        public LoginCommand(string email, string password)
        {
            Email = email;
            Password = password;
        }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}
