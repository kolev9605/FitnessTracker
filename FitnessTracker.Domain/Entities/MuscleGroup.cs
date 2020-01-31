using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessTracker.Domain.Entities
{
    public class MuscleGroup
    {
        public MuscleGroup()
        {
            ExerciseMuscleGroups = new List<ExerciseMuscleGroup>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string ScientificName { get; set; }

        public int MuscleGroupTypeId { get; set; }

        public MuscleGroupType MuscleGroupType { get; set; }

        public ICollection<ExerciseMuscleGroup> ExerciseMuscleGroups { get; set; }
    }
}
