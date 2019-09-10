using FitnessTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessTracker.Persistance.Configurations
{
    class WorkoutItemConfiguration : IEntityTypeConfiguration<WorkoutItem>
    {
        public void Configure(EntityTypeBuilder<WorkoutItem> builder)
        {
        }
    }
}
