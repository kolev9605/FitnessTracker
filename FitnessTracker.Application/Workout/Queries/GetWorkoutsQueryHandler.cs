using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace FitnessTracker.Application.Workout.Queries
{
    public class GetWorkoutsQueryHandler : IRequestHandler<GetWorkoutsQuery, WorkoutListModel>
    {
        public Task<WorkoutListModel> Handle(GetWorkoutsQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
