using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessTracker.Domain.Entities
{
    public class MuscleGroupType
    {
        public MuscleGroupType()
        {
            MuscleGroups = new List<MuscleGroup>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<MuscleGroup> MuscleGroups { get; set; }
    }
}
