using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessTracker.Application.Workouts.Queries
{
    public class WorkoutModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<WorkoutItemModel> WorkoutItems { get; set; }
    }
}
