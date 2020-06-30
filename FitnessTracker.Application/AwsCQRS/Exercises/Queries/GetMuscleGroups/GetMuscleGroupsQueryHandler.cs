using AutoMapper;
using AutoMapper.QueryableExtensions;
using FitnessTracker.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace FitnessTracker.Application.AwsCQRS.Exercises.Queries.GetMuscleGroups
{
    public class GetMuscleGroupsQueryHandler : IRequestHandler<GetMuscleGroupsQuery, MuscleGroupsListModel>
    {
        private readonly IApplicationDbContext _applicationDbContext;
        private readonly IMapper _mapper;

        public GetMuscleGroupsQueryHandler(IApplicationDbContext applicationDbContext, IMapper mapper)
        {
            _applicationDbContext = applicationDbContext;
            _mapper = mapper;
        }
        public async Task<MuscleGroupsListModel> Handle(GetMuscleGroupsQuery request, CancellationToken cancellationToken)
        {
            var model = new MuscleGroupsListModel();

            model.MuscleGroups = await _applicationDbContext
                .MuscleGroups.ProjectTo<MuscleGroupModel>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return model;
        }
    }
}
