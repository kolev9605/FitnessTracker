using FitnessTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitnessTracker.Persistance.Configurations
{
    public class ExerciseConfiguration : IEntityTypeConfiguration<Exercise>
    {
        public void Configure(EntityTypeBuilder<Exercise> builder)
        {
            builder
                .HasMany(e => e.WorkoutItems)
                .WithOne(wi => wi.Exercise);

            builder.Property(e => e.Name)
                .IsRequired();
        }
    }
}
