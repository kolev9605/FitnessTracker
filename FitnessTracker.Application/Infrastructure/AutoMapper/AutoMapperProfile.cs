﻿using AutoMapper;
using FitnessTracker.Application.Exercises.Queries.GetExercises;
using FitnessTracker.Application.Workouts.Queries;
using FitnessTracker.Domain.Entities;
using System.Linq;

namespace FitnessTracker.Application.Infrastructure.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Exercise, ExerciseModel>();

            CreateMap<Workout, WorkoutModel>();
            CreateMap<WorkoutItem, WorkoutItemModel>()
                .ForMember(dest => dest.ExerciseName, opt => opt.MapFrom(src => src.Exercise.Name));
        }
    }
}
