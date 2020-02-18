namespace FitnessTracker.Application.CQRS.Workouts.Commands.AddWorkout
{
    public class AddWorkoutItemModel
    {
        public int ExerciseId { get; set; }

        public int Sets { get; set; }

        public int Reps { get; set; }

        public int Weight { get; set; }
    }
}
