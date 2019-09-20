using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessTracker.Application.Exercises.Queries.GetExercises
{
    public class GetExercisesQuery : IRequest<ExerciseListModel>
    {
    }
}
