using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessTracker.Application.CQRS.Exercises.Queries.GetMuscleGroups
{
    public class GetMuscleGroupsQuery : IRequest<MuscleGroupsListModel>
    {
    }
}
