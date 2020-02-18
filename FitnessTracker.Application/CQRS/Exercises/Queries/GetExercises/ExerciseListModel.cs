using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessTracker.Application.CQRS.Exercises.Queries.GetExercises
{
    public class ExerciseListModel
    {
        public IEnumerable<ExerciseModel> Exercises { get; set; }
    }
}
