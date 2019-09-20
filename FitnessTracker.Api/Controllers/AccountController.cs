using FitnessTracker.Application.Authentication.Commands.Login;
using FitnessTracker.Application.Exceptions;
using FitnessTracker.Application.Interfaces;
using FitnessTracker.Application.Models.Account;
using FitnessTracker.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Api.Controllers
{
    [AllowAnonymous]
    [Route("api/Account")]
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IConfiguration _configuration;
        private readonly IPasswordHasher<ApplicationUser> _passwordHasher;
        private readonly IJwtTokenService _jwtTokenService;

        public AccountController(
            UserManager<ApplicationUser> userManager,
            IConfiguration configuration,
            IPasswordHasher<ApplicationUser> passwordHasher,
            IJwtTokenService jwtTokenService)
        {
            _userManager = userManager;
            _configuration = configuration;
            _passwordHasher = passwordHasher;
            _jwtTokenService = jwtTokenService;
        }

        [HttpPost]
        [Route("Login")]
        public async Task<ActionResult<LoginResultModel>> Login([FromBody] LoginCommand model)
        {
            var applicationUser = await _userManager.Users.FirstOrDefaultAsync(r => r.Email == model.Email);
            if (applicationUser == null)
            {
                throw new AuthenticationException($"User with email {model.Email} does not exist");
            }

            PasswordVerificationResult result = this._passwordHasher.VerifyHashedPassword(applicationUser, applicationUser.PasswordHash, model.Password);
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

        [HttpPost]
        [Route("Register")]
        public async Task<ActionResult<AuthenticationResultModel>> Register([FromBody] RegisterModel model)
        {
            if (model.Password != model.ConfirmPassword)
            {
                throw new AuthenticationException("Confirm password and password must match");
            }

            var applicationUser = new ApplicationUser
            {
                UserName = model.Email,
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName
            };

            var result = await _userManager.CreateAsync(applicationUser, model.Password);
            if (result.Succeeded)
            {
                var token = GenerateJwtToken(model.Email, applicationUser);

                return Ok(token);
            }
            else
            {
                throw new AuthenticationException(string.Join(", ", result.Errors.Select(e => e.Description)));
            }
        }

        private AuthenticationResultModel GenerateJwtToken(string email, ApplicationUser user)
        {
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.NameIdentifier, user.Id)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtKey"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expires = DateTime.Now.AddDays(Convert.ToDouble(_configuration["JwtExpireDays"]));

            var token = new JwtSecurityToken(
                issuer: _configuration["JwtIssuer"],
                audience: _configuration["JwtIssuer"],
                claims: claims,
                expires: expires,
                signingCredentials: creds
            );


            var tokenString = new JwtSecurityTokenHandler().WriteToken(token);

            var authenticationResultModel = new AuthenticationResultModel()
            {
                Email = email,
                Token = tokenString,
                ExpirationDate = expires,
                UserId = user.Id
            };

            return authenticationResultModel;
        }
    }
}