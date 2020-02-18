using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessTracker.Application.CQRS.Workouts.Queries.GetWorkouts
{
    public class WorkoutItemModel
    {
        public int Id { get; set; }

        public string ExerciseName { get; set; }

        public int Sets { get; set; }

        public int Reps { get; set; }
    }
}
