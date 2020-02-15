using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessTracker.Application.CQRS.Workouts.Queries.GetWorkouts
{
    public class GetWorkoutsQuery : IRequest<WorkoutListModel>
    {
    }
}
