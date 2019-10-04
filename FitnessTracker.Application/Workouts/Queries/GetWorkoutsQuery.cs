using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessTracker.Application.Workouts.Queries
{
    public class GetWorkoutsQuery : IRequest<WorkoutListModel>
    {
    }
}
