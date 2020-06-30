using AutoMapper;
using FitnessTracker.Application.Exceptions;
using FitnessTracker.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FitnessTracker.Application.AwsCQRS.Workouts.Commands.DeleteWorkout
{
    public class DeleteWorkoutCommandHandler : IRequestHandler<DeleteWorkoutCommand>
    {
        private readonly IApplicationDbContext _applicationDbContext;
        private readonly IMapper _mapper;

        public DeleteWorkoutCommandHandler(IApplicationDbContext applicationDbContext, IMapper mapper)
        {
            _applicationDbContext = applicationDbContext;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(DeleteWorkoutCommand request, CancellationToken cancellationToken)
        {
            var workout = await _applicationDbContext.Workouts
                .Where(w => w.Id == request.Id)
                .FirstOrDefaultAsync();

            if (workout == null)
            {
                throw new NotFoundException("workout", request.Id);
            }

            _applicationDbContext.Workouts.Remove(workout);
            await _applicationDbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
