using FluentValidation;

namespace FitnessTracker.Application.Exercises.Queries.GetExercises
{
    public class GetExercisesQueryValidator : AbstractValidator<GetExercisesQuery>
    {
        public GetExercisesQueryValidator()
        {
            //RuleFor(x => x.Number).LessThan(10);
        }
    }
}
