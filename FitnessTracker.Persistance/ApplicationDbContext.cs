using FitnessTracker.Application.Interfaces;
using FitnessTracker.Domain.Entities;
using FitnessTracker.Persistance.Seeders;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FitnessTracker.Persistance
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IApplicationDbContext
    {
        public DbSet<Exercise> Exercises { get; set; }

        public DbSet<Workout> Workouts { get; set; }

        public DbSet<WorkoutItem> WorkoutItems { get; set; }

        public DbSet<ExerciseMuscleGroup> ExerciseMuscleGroups { get; set; }

        public DbSet<MuscleGroup> MuscleGroups { get; set; }

        public DbSet<MuscleGroupType> MuscleGroupTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

            modelBuilder.Seed();

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=fitness_tracker;Username=postgres;Password=K0l3vK0l3v");
        }
    }
}
