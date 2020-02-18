using FitnessTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitnessTracker.Persistance.Configurations
{
    public class ExerciseMuscleGroupConfiguration : IEntityTypeConfiguration<ExerciseMuscleGroup>
    {
        public void Configure(EntityTypeBuilder<ExerciseMuscleGroup> builder)
        {
            builder.HasKey(emg => new { emg.ExerciseId, emg.MuscleGroupId });

            builder.HasOne(emg => emg.MuscleGroup)
                .WithMany(mg => mg.ExerciseMuscleGroups)
                .HasForeignKey(emg => emg.MuscleGroupId);

            builder.HasOne(emg => emg.Exercise)
                .WithMany(e => e.ExerciseMuscleGroups)
                .HasForeignKey(emg => emg.ExerciseId);

            builder.Property(emg => emg.MoverType)
                .IsRequired();
        }
    }
}
