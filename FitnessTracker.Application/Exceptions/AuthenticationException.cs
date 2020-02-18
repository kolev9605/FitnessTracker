using System;

namespace FitnessTracker.Application.Exceptions
{
    public class AuthenticationException : Exception
    {
        public AuthenticationException(string message) 
            : base($"Authentication failed: {message}")
        {
        }
    }
}
