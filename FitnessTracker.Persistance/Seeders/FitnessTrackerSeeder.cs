using FitnessTracker.Application.Constants;
using FitnessTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace FitnessTracker.Persistance.Seeders
{
    public static class FitnessTrackerSeeder
    {
        private static Dictionary<string, MuscleGroup> muscleGroups = new Dictionary<string, MuscleGroup>()
        {
            {
                MuscleGroups.TrapsName, 
                new MuscleGroup 
                { 
                    Id = 1, 
                    Name = MuscleGroups.TrapsName, 
                    ScientificName = MuscleGroups.TrapsScientificName, 
                    MuscleGroupTypeId = 1 
                }
            },
            {
                MuscleGroups.MiddleBackName, 
                new MuscleGroup 
                { 
                    Id = 2, 
                    Name = MuscleGroups.MiddleBackName, 
                    ScientificName = MuscleGroups.MiddleBackScientificName, 
                    MuscleGroupTypeId = 1 
                }
            },
            {
                MuscleGroups.LatsName, 
                new MuscleGroup 
                { 
                    Id = 3, 
                    Name = MuscleGroups.LatsName, 
                    ScientificName = MuscleGroups.LatsScientificName, 
                    MuscleGroupTypeId = 1 
                }
            },
            {
                MuscleGroups.LowerBackName, 
                new MuscleGroup 
                { 
                    Id = 4, 
                    Name = MuscleGroups.LowerBackName, 
                    ScientificName = MuscleGroups.LowerBackScientificName, 
                    MuscleGroupTypeId = 1 
                }
            },
            {
                MuscleGroups.UpperChestName, 
                new MuscleGroup 
                { 
                    Id = 5, 
                    Name = MuscleGroups.UpperChestName, 
                    ScientificName = MuscleGroups.UpperChestScientificName, 
                    MuscleGroupTypeId = 2 
                }
            },
            {
                MuscleGroups.LowerChestName, 
                new MuscleGroup 
                { 
                    Id = 6, 
                    Name = MuscleGroups.LowerChestName, 
                    ScientificName = MuscleGroups.LowerChestScientificName, 
                    MuscleGroupTypeId = 2 
                }
            },
            {
                MuscleGroups.AbsName, 
                new MuscleGroup 
                { 
                    Id = 7, 
                    Name = MuscleGroups.AbsName, 
                    ScientificName = MuscleGroups.AbsScientificName, 
                    MuscleGroupTypeId = 3 
                }
            },
            {
                MuscleGroups.FrontDeltsName, 
                new MuscleGroup 
                { 
                    Id = 8, 
                    Name = MuscleGroups.FrontDeltsName, 
                    ScientificName = MuscleGroups.FrontDeltsScientificName, 
                    MuscleGroupTypeId = 4 
                }
            },
            {
                MuscleGroups.SideDeltsName, 
                new MuscleGroup 
                { 
                    Id = 9, 
                    Name = MuscleGroups.SideDeltsName, 
                    ScientificName = MuscleGroups.SideDeltsScientificName, 
                    MuscleGroupTypeId = 4 
                }
            },
            {
                MuscleGroups.RearDeltsName, 
                new MuscleGroup 
                { 
                    Id = 10, 
                    Name = MuscleGroups.RearDeltsName, 
                    ScientificName = MuscleGroups.RearDeltsScientificName, 
                    MuscleGroupTypeId = 4 
                }
            },
            {
                MuscleGroups.TricepsName, 
                new MuscleGroup 
                { 
                    Id = 11, 
                    Name = MuscleGroups.TricepsName, 
                    ScientificName = MuscleGroups.TricepsScientificName, 
                    MuscleGroupTypeId = 5 
                }
            },
            {
                MuscleGroups.BicepsName, 
                new MuscleGroup 
                { 
                    Id = 12, 
                    Name = MuscleGroups.BicepsName, 
                    ScientificName = MuscleGroups.BicepsScientificName, 
                    MuscleGroupTypeId = 5 
                }
            },
            {
                MuscleGroups.ForearmsName,
                new MuscleGroup 
                { 
                    Id = 13, 
                    Name = MuscleGroups.ForearmsName, 
                    ScientificName = MuscleGroups.ForearmsScientificName, 
                    MuscleGroupTypeId = 5 
                }
            },
            {
                MuscleGroups.GlutesName, 
                new MuscleGroup 
                { 
                    Id = 14, 
                    Name = MuscleGroups.GlutesName, 
                    ScientificName = MuscleGroups.GlutesScientificName, 
                    MuscleGroupTypeId = 6 
                }
            },
            {
                MuscleGroups.QuadricepsName, 
                new MuscleGroup 
                { 
                    Id = 15, 
                    Name = MuscleGroups.QuadricepsName, 
                    ScientificName = MuscleGroups.QuadricepsScientificName, 
                    MuscleGroupTypeId = 6 
                }
            },
            {
                MuscleGroups.HamstringsName, 
                new MuscleGroup 
                { 
                    Id = 16, 
                    Name = MuscleGroups.HamstringsName, 
                    ScientificName = MuscleGroups.HamstringsScientificName, 
                    MuscleGroupTypeId = 6 
                }
            },
            {
                MuscleGroups.CalvesName, 
                new MuscleGroup 
                { 
                    Id = 17, 
                    Name = MuscleGroups.CalvesName, 
                    ScientificName = MuscleGroups.CalvesScientificName, 
                    MuscleGroupTypeId = 6 
                } 
            }
        };

        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.SeedMuscleGroupTypes();
            modelBuilder.SeedMuscleGroups(muscleGroups);
            modelBuilder.SeedExercises(muscleGroups);
        }
    }
}
