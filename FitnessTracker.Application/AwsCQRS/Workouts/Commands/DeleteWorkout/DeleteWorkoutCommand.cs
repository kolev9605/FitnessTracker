using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessTracker.Application.AwsCQRS.Workouts.Commands.DeleteWorkout
{
    public class DeleteWorkoutCommand : IRequest
    {
        public int Id { get; set; }
    }
}
