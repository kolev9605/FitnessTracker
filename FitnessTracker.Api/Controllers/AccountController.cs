using FitnessTracker.Application.Authentication.Commands.Login;
using FitnessTracker.Application.Authentication.Commands.Register;
using FitnessTracker.Application.Models.Account;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FitnessTracker.Api.Controllers
{
    [AllowAnonymous]
    [Route("api/Account")]
    public class AccountController : Controller
    {
        private readonly IMediator _mediator;

        public AccountController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("Login")]
        public async Task<ActionResult<LoginResultModel>> Login([FromBody] LoginCommand model)
        {
            var result = await _mediator.Send(model);

            return result;
        }

        [HttpPost]
        [Route("Register")]
        public async Task<ActionResult<RegisterResultModel>> Register([FromBody] RegisterCommand model)
        {
            var result = await _mediator.Send(model);

            return result;
            return null;
            //if (model.Password != model.ConfirmPassword)
            //{
            //    throw new AuthenticationException("Confirm password and password must match");
            //}

            //var applicationUser = new ApplicationUser
            //{
            //    UserName = model.Email,
            //    Email = model.Email,
            //    FirstName = model.FirstName,
            //    LastName = model.LastName
            //};

            //var result = await _userManager.CreateAsync(applicationUser, model.Password);
            //if (result.Succeeded)
            //{
            //    var jtwTokenCreationResultModel = GenerateJwtToken(applicationUser.Email, applicationUser);
            //    LoginResultModel loginResultModel = new LoginResultModel()
            //    {
            //        Email = jtwTokenCreationResultModel.Email,
            //        ExpirationDate = jtwTokenCreationResultModel.ExpirationDate,
            //        Token = jtwTokenCreationResultModel.Token,
            //        UserId = jtwTokenCreationResultModel.UserId
            //    };

            //    return Ok(loginResultModel);
            //}
            //else
            //{
            //    throw new AuthenticationException(string.Join(", ", result.Errors.Select(e => e.Description)));
            //}
        }

        //private AuthenticationResultModel GenerateJwtToken(string email, ApplicationUser user)
        //{
        //    var claims = new List<Claim>
        //    {
        //        new Claim(JwtRegisteredClaimNames.Sub, email),
        //        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
        //        new Claim(ClaimTypes.NameIdentifier, user.Id)
        //    };

        //    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtKey"]));
        //    var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
        //    var expires = DateTime.Now.AddDays(Convert.ToDouble(_configuration["JwtExpireDays"]));

        //    var token = new JwtSecurityToken(
        //        issuer: _configuration["JwtIssuer"],
        //        audience: _configuration["JwtIssuer"],
        //        claims: claims,
        //        expires: expires,
        //        signingCredentials: creds
        //    );


        //    var tokenString = new JwtSecurityTokenHandler().WriteToken(token);

        //    var authenticationResultModel = new AuthenticationResultModel()
        //    {
        //        Email = email,
        //        Token = tokenString,
        //        ExpirationDate = expires,
        //        UserId = user.Id
        //    };

        //    return authenticationResultModel;
        //}
    }
}