using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessTracker.Serverless
{
    public class CognitoGroupAuthorizationRequirement : IAuthorizationRequirement
    {
        public CognitoGroupAuthorizationRequirement(string cognitoGroup)
        {
            CognitoGroup = cognitoGroup;
        }

        public string CognitoGroup { get; set; }
    }
}
