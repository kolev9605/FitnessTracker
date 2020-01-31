using FitnessTracker.Application.Constants;
using FitnessTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessTracker.Persistance.Seeders
{
    public static class ExerciseSeeder
    {
        public static void SeedExercises(this ModelBuilder modelBuilder, Dictionary<string, MuscleGroup> muscleGroupsByName)
        {
            modelBuilder.Entity<Exercise>(e =>
            {
                e.HasData(new Exercise
                {
                    Id = 1,
                    Name = "Bench Press",
                });

                e.OwnsMany(emb => emb.ExerciseMuscleGroups).HasData(
                    new
                    {
                        ExerciseId = 1,
                        MoverType = MoverType.Primary,
                        MuscleGroupId = muscleGroupsByName[MuscleGroups.UpperChestName].Id
                    },
                    new
                    {
                        ExerciseId = 1,
                        MoverType = MoverType.Primary,
                        MuscleGroupId = muscleGroupsByName[MuscleGroups.LowerChestName].Id
                    },
                    new
                    {
                        ExerciseId = 1,
                        MoverType = MoverType.Secondary,
                        MuscleGroupId = muscleGroupsByName[MuscleGroups.FrontDeltsName].Id
                    },
                    new
                    {
                        ExerciseId = 1,
                        MoverType = MoverType.Secondary,
                        MuscleGroupId = muscleGroupsByName[MuscleGroups.TricepsName].Id
                    },
                    new
                    {
                        ExerciseId = 1,
                        MoverType = MoverType.Other,
                        MuscleGroupId = muscleGroupsByName[MuscleGroups.BicepsName].Id,
                    }
                );            
            });

        }
    }
}
