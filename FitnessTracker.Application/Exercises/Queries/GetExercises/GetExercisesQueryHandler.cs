using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using FitnessTracker.Application.Interfaces;
using FitnessTracker.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace FitnessTracker.Application.Exercises.Queries.GetExercises
{
    public class GetExercisesQueryHandler : IRequestHandler<GetExercisesQuery, ExerciseListModel>
    {
        private readonly IApplicationDbContext _applicationDbContext;
        private readonly IMapper _mapper;

        public GetExercisesQueryHandler(IApplicationDbContext applicationDbContext, IMapper mapper)
        {
            _applicationDbContext = applicationDbContext;
            _mapper = mapper;
        }

        public async Task<ExerciseListModel> Handle(GetExercisesQuery request, CancellationToken cancellationToken)
        {
            var model = new ExerciseListModel();

            model.Exercises = await _applicationDbContext
                .Exercises.ProjectTo<ExerciseModel>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return model;
        }
    }
}
