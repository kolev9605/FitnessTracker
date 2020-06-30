using Amazon.S3;
using Amazon.S3.Model;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using FitnessTracker.Application.Constants;
using FitnessTracker.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace FitnessTracker.Application.AwsCQRS.Exercises.Queries.GetExercises
{
    public class GetExercisesQueryHandler : IRequestHandler<GetExercisesQuery, ExerciseListModel>
    {
        private readonly IMapper _mapper;
        private readonly IAmazonS3 _client;

        public GetExercisesQueryHandler(IMapper mapper, IAmazonS3 client)
        {
            _mapper = mapper;
            _client = client;
        }

        public async Task<ExerciseListModel> Handle(GetExercisesQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var s3Request = new GetObjectRequest
                {
                    BucketName = AwsConstants.JsonsBucketName,
                    Key = AwsConstants.ExercisesJsonKey
                };

                using (var response = await _client.GetObjectAsync(s3Request))
                {
                    
                }
            }
            catch (System.Exception e)
            {

                throw;
            }

            return null;
        }
    }
}
