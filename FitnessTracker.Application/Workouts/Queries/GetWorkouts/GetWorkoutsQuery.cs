using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessTracker.Application.Workouts.Queries.GetWorkouts
{
    public class GetWorkoutsQuery : IRequest<WorkoutListModel>
    {
    }
}
