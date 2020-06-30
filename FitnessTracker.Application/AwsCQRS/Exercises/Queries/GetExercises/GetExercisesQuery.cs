using MediatR;

namespace FitnessTracker.Application.AwsCQRS.Exercises.Queries.GetExercises
{
    public class GetExercisesQuery : IRequest<ExerciseListModel>
    {
    }
}
