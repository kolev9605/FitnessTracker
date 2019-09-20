using System.Threading;
using System.Threading.Tasks;
using FitnessTracker.Application.Exceptions;
using FitnessTracker.Application.Interfaces;
using FitnessTracker.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace FitnessTracker.Application.Authentication.Commands.Login
{
    public class LoginCommandHandler : IRequestHandler<LoginCommand, LoginResultModel>
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IConfiguration _configuration;
        private readonly IPasswordHasher<ApplicationUser> _passwordHasher;
        private readonly IJwtTokenService _jwtTokenService;

        private readonly IApplicationDbContext _applicationDbContext;

        public LoginCommandHandler(
            IApplicationDbContext applicationDbContext,
            //UserManager<ApplicationUser> userManager,
            IConfiguration configuration,
            IPasswordHasher<ApplicationUser> passwordHasher,
            IJwtTokenService jwtTokenService
            )
        {
            _applicationDbContext = applicationDbContext;
            //_userManager = userManager;
            _configuration = configuration;
            _passwordHasher = passwordHasher;
            _jwtTokenService = jwtTokenService;
        }

        public async Task<LoginResultModel> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            var applicationUser = await _userManager.Users.FirstOrDefaultAsync(r => r.Email == request.Email);
            if (applicationUser == null)
            {
                throw new AuthenticationException($"User with email {request.Email} does not exist");
            }

            PasswordVerificationResult result = this._passwordHasher.VerifyHashedPassword(applicationUser, applicationUser.PasswordHash, request.Password);
            if (result == PasswordVerificationResult.Success)
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

                throw new AuthenticationException("Invalid password");

            }
            else
            {
                throw new AuthenticationException("Invalid password");
            }
        }
    }
}
