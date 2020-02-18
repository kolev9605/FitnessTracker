using System.Collections.Generic;

namespace FitnessTracker.Application.CQRS.Exercises.Queries.GetMuscleGroups
{
    public class MuscleGroupsListModel
    {
        public IEnumerable<MuscleGroupModel> MuscleGroups { get; set; }
    }
}
