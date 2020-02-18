using MediatR;

namespace FitnessTracker.Application.CQRS.Exercises.Queries.GetExercises
{
    public class GetExercisesQuery : IRequest<ExerciseListModel>
    {
    }
}
