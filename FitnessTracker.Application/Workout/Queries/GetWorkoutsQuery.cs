using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessTracker.Application.Workout.Queries
{
    public class GetWorkoutsQuery : IRequest<WorkoutListModel>
    {
    }
}
