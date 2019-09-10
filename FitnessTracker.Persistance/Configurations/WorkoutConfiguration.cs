using FitnessTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessTracker.Persistance.Configurations
{
    public class WorkoutConfiguration : IEntityTypeConfiguration<Workout>
    {
        public void Configure(EntityTypeBuilder<Workout> builder)
        {
            builder
                .HasMany(w => w.WorkoutItems)
                .WithOne(wi => wi.Workout);

            builder.Property(w => w.Name)
                .IsRequired();
        }
    }
}
