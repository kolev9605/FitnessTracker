using AutoMapper;
using AutoMapper.QueryableExtensions;
using FitnessTracker.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FitnessTracker.Application.Workouts.Queries
{
    public class GetWorkoutsQueryHandler : IRequestHandler<GetWorkoutsQuery, WorkoutListModel>
    {
        private readonly IApplicationDbContext _applicationDbContext;
        private readonly IMapper _mapper;

        public GetWorkoutsQueryHandler(IApplicationDbContext applicationDbContext, IMapper mapper)
        {
            _applicationDbContext = applicationDbContext;
            _mapper = mapper;
        }

        public async Task<WorkoutListModel> Handle(GetWorkoutsQuery request, CancellationToken cancellationToken)
        {
            //var workouts = await _applicationDbContext.Workouts
            //    .Select(w => new WorkoutModel
            //    {
            //        Id = w.Id,
            //        Name = w.Name,
            //        WorkoutItems = w.WorkoutItems.Select(wi => new WorkoutItemModel
            //        {
            //            Id =wi.Id,
            //            ExerciseName = wi.Exercise.Name,
            //            Reps = wi.Reps,
            //            Sets = wi.Sets
            //        }).ToList()
            //    })
            //    .ToListAsync(cancellationToken);

            var workouts = await _applicationDbContext.Workouts
                .ProjectTo<WorkoutModel>(_mapper.ConfigurationProvider)
                .ToListAsync();

            var workoutListModel = new WorkoutListModel()
            {
                Workouts = workouts
            };

            return workoutListModel;
        }
    }
}
