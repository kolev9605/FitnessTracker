using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessTracker.Application.Workouts.Queries.GetWorkouts
{
    public class WorkoutListModel
    {
        public IEnumerable<WorkoutModel> Workouts { get; set; }
    }
}
