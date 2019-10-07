using AutoMapper;
using FitnessTracker.Application.Interfaces;
using FitnessTracker.Domain.Entities;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FitnessTracker.Application.Workouts.Commands.AddWorkout
{
    class AddWorkoutCommandHandler : IRequestHandler<AddWorkoutCommand>
    {
        private readonly IApplicationDbContext _applicationDbContext;
        private readonly IMapper _mapper;

        public AddWorkoutCommandHandler(IApplicationDbContext applicationDbContext, IMapper mapper)
        {
            _applicationDbContext = applicationDbContext;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(AddWorkoutCommand request, CancellationToken cancellationToken)
        {
            var workout = new Workout()
            {
                Name = request.Name,
                WorkoutItems = request.WorkoutItems.Select(x => new WorkoutItem()
                {
                    ExerciseId = x.ExerciseId,
                    Reps = x.Reps,
                    Sets = x.Sets
                }).ToList()
            };

            await _applicationDbContext.Workouts.AddAsync(workout);
            await _applicationDbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
