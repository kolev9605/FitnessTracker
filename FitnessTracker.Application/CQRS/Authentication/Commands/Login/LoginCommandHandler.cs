using FitnessTracker.Application.Exceptions;
using FitnessTracker.Application.Interfaces;
using FitnessTracker.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace FitnessTracker.Application.CQRS.Authentication.Commands.Login
{
    public class LoginCommandHandler : IRequestHandler<LoginCommand, LoginResultModel>
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IJwtTokenService _jwtTokenService;

        public LoginCommandHandler(
            UserManager<ApplicationUser> userManager,
            IJwtTokenService jwtTokenService)
        {
            _userManager = userManager;
            _jwtTokenService = jwtTokenService;
        }

        public async Task<LoginResultModel> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            var applicationUser = await _userManager.Users.FirstOrDefaultAsync(r => r.Email == request.Email);
            if (applicationUser == null)
            {
                throw new AuthenticationException($"User with email {request.Email} does not exist");
            }

            var isPasswordValid = await _userManager.CheckPasswordAsync(applicationUser, request.Password);
            if (isPasswordValid)
            {
                var jtwTokenCreationResultModel = _jwtTokenService.GenerateJwtToken(applicationUser.Email, applicationUser);

                LoginResultModel loginResultModel = new LoginResultModel()
                {
                    Email = jtwTokenCreationResultModel.Email,
                    ExpirationDate = jtwTokenCreationResultModel.ExpirationDate,
                    Token = jtwTokenCreationResultModel.Token,
                    UserId = jtwTokenCreationResultModel.UserId
                };

                return loginResultModel;

            }
            else
            {
                throw new AuthenticationException("Invalid password");
            }
        }
    }
}
