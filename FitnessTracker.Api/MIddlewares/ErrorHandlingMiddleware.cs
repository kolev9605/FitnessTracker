using FitnessTracker.Application.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Threading.Tasks;

namespace FitnessTracker.Api.MIddlewares
{
    public class ErrorHandlingMiddleware
    {
        private readonly RequestDelegate next;

        public ErrorHandlingMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            var code = HttpStatusCode.InternalServerError; // 500 if unexpected
            var result = JsonConvert.SerializeObject(new { errorMessage = ex.Message });

            if (ex is AuthenticationException)
            {
                code = HttpStatusCode.Unauthorized;
            }
            else if (ex is ValidationException)
            {
                //TODO: Use for logging or more user-friendly messages?
                //var dict = ((ValidationException)ex).Failures;
                //var json = new JsonResult(dict);
                code = HttpStatusCode.BadRequest;
            }
            else if (ex is NotFoundException)
            {
                code = HttpStatusCode.NotFound;
            }
            
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)code;
            return context.Response.WriteAsync(result);
        }
    }
}
