using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessTracker.Application.AwsCQRS.Exercises.Queries.GetMuscleGroups
{
    public class GetMuscleGroupsQuery : IRequest<MuscleGroupsListModel>
    {
    }
}
