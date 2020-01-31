using FitnessTracker.Application.Constants;
using FitnessTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FitnessTracker.Persistance.Seeders
{
    public static class MuscleGroupTypeSeeder
    {
        public static void SeedMuscleGroupTypes(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MuscleGroupType>().HasData(
                new MuscleGroupType { Id = 1, Name = MuscleGroupTypes.BackName },
                new MuscleGroupType { Id = 2, Name = MuscleGroupTypes.ChestName },
                new MuscleGroupType { Id = 3, Name = MuscleGroupTypes.AbsName },
                new MuscleGroupType { Id = 4, Name = MuscleGroupTypes.ShouldersName },
                new MuscleGroupType { Id = 5, Name = MuscleGroupTypes.ArmsName },
                new MuscleGroupType { Id = 6, Name = MuscleGroupTypes.LegsName }
            );
        }
    }
}
