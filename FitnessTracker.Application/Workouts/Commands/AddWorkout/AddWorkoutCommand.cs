using MediatR;
using System.Collections.Generic;

namespace FitnessTracker.Application.Workouts.Commands.AddWorkout
{
    public class AddWorkoutCommand : IRequest
    {
        public string Name { get; set; }

        public IEnumerable<AddWorkoutItemModel> WorkoutItems { get; set; }
    }
}
