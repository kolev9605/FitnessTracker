using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessTracker.Application.AwsCQRS.Exercises.Queries.GetExercises
{
    public class ExerciseListModel
    {
        public IEnumerable<ExerciseModel> Exercises { get; set; }
    }
}
