using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessTracker.Application.AwsCQRS.Exercises.Queries.GetMuscleGroups
{
    public class MuscleGroupModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ScientificName { get; set; }

        public string MuscleGroupTypeName { get; set; }
    }
}
