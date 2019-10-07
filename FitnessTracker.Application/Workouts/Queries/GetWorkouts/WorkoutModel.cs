using System.Collections.Generic;

namespace FitnessTracker.Application.Workouts.Queries.GetWorkouts
{
    public class WorkoutModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IList<WorkoutItemModel> WorkoutItems { get; set; }
    }
}
