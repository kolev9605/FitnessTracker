using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using FitnessTracker.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FitnessTracker.Application.Exercises.Queries.GetExercises
{
    public class GetExercisesQueryHandler : IRequestHandler<GetExercisesQuery, ExerciseListModel>
    {
        private readonly IApplicationDbContext applicationDbContext;
        private readonly IMapper mapper;

        public GetExercisesQueryHandler(IApplicationDbContext applicationDbContext, IMapper mapper)
        {
            this.applicationDbContext = applicationDbContext;
            this.mapper = mapper;
        }

        public async Task<ExerciseListModel> Handle(GetExercisesQuery request, CancellationToken cancellationToken)
        {
            var model = new ExerciseListModel();

            model.ExerciseModels = await this.applicationDbContext
                .Exercises.ProjectTo<ExerciseModel>(mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return model;
        }
    }
}
