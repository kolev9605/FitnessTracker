using FitnessTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FitnessTracker.Persistance.Seeders
{
    public static class MuscleGroupSeeder
    {
        public static void SeedMuscleGroups(this ModelBuilder modelBuilder, Dictionary<string, MuscleGroup> muscleGroups)
        {
            modelBuilder.Entity<MuscleGroup>().HasData(muscleGroups.Select(mg => mg.Value));
        }
    }
}
