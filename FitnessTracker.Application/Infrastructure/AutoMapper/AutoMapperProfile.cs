using AutoMapper;
using FitnessTracker.Application.Exercises.Queries.GetExercises;
using FitnessTracker.Domain.Entities;

namespace FitnessTracker.Application.Infrastructure.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Exercise, ExerciseModel>();
        }
    }
}
