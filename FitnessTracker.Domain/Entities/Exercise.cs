using System.Collections.Generic;

namespace FitnessTracker.Domain.Entities
{
    public class Exercise
    {
        public Exercise()
        {
            WorkoutItems = new List<WorkoutItem>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<WorkoutItem> WorkoutItems { get; set; }
    }
}
