using FitnessTracker.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FitnessTracker.Application.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Exercise> Exercises { get; set; }

        DbSet<Workout> Workouts { get; set; }

        DbSet<WorkoutItem> WorkoutItems { get; set; }

        DbSet<ExerciseMuscleGroup> ExerciseMuscleGroups { get; set; }

        DbSet<MuscleGroup> MuscleGroups { get; set; }

        DbSet<MuscleGroupType> MuscleGroupTypes { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
