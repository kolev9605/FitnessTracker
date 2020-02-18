using FluentValidation;

namespace FitnessTracker.Application.CQRS.Authentication.Commands.Login
{
    public class LoginCommandValidator : AbstractValidator<LoginCommand>
    {
        public LoginCommandValidator()
        {
            RuleFor(x => x.Email).NotEmpty();
            RuleFor(x => x.Password).MinimumLength(6).NotEmpty();
        }
    }
}
