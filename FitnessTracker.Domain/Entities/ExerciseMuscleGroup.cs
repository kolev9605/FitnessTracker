namespace FitnessTracker.Domain.Entities
{
    public class ExerciseMuscleGroup
    {
        public int ExerciseId { get; set; }

        public Exercise Exercise { get; set; }

        public int MuscleGroupId { get; set; }

        public MuscleGroup MuscleGroup { get; set; }

        public MoverType MoverType { get; set; }
    }
}
