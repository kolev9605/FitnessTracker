using FitnessTracker.Application.Exceptions;
using FitnessTracker.Application.Interfaces;
using FitnessTracker.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FitnessTracker.Application.Authentication.Commands.Register
{
    public class RegisterCommandHandler : IRequestHandler<RegisterCommand, RegisterResultModel>
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IJwtTokenService _jwtTokenService;

        public RegisterCommandHandler(
            UserManager<ApplicationUser> userManager,
            IJwtTokenService jwtTokenService)
        {
            _userManager = userManager;
            _jwtTokenService = jwtTokenService;
        }

        public async Task<RegisterResultModel> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            var applicationUser = new ApplicationUser
            {
                UserName = request.Email,
                Email = request.Email,
                FirstName = request.FirstName,
                LastName = request.LastName
            };

            var result = await _userManager.CreateAsync(applicationUser, request.Password);
            if (result.Succeeded)
            {
                var jtwTokenCreationResultModel = _jwtTokenService.GenerateJwtToken(applicationUser.Email, applicationUser);
                RegisterResultModel loginResultModel = new RegisterResultModel()
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
                throw new AuthenticationException(string.Join(", ", result.Errors.Select(e => e.Description)));
            }
        }
    }
}
