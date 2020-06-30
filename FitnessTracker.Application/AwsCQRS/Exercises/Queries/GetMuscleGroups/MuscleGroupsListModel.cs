using System.Collections.Generic;

namespace FitnessTracker.Application.AwsCQRS.Exercises.Queries.GetMuscleGroups
{
    public class MuscleGroupsListModel
    {
        public IEnumerable<MuscleGroupModel> MuscleGroups { get; set; }
    }
}
