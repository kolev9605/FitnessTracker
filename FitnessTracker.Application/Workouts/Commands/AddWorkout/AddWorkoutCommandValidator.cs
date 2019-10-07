using FluentValidation;
using System.Linq;

namespace FitnessTracker.Application.Workouts.Commands.AddWorkout
{
    public class AddWorkoutCommandValidator : AbstractValidator<AddWorkoutCommand>
    {
        public AddWorkoutCommandValidator()
        {
            RuleFor(x => x.Name)
                .NotNull()
                .NotEmpty();

            RuleFor(x => x.WorkoutItems)
                .NotNull()
                .Must(x => x.Any());

            RuleForEach(x => x.WorkoutItems)
                .Must(x => x.ExerciseId != 0)
                .Must(x => x.Reps != 0)
                .Must(x => x.Sets != 0);
        }
    }
}
