using FitnessTracker.Application.Constants;
using FitnessTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using System.Linq;

namespace FitnessTracker.Persistance.Configurations
{
    public class MuscleGroupConfiguration : IEntityTypeConfiguration<MuscleGroup>
    {
        public void Configure(EntityTypeBuilder<MuscleGroup> builder)
        {
            builder.Property(mg => mg.Name)
                .IsRequired();

            builder.Property(mg => mg.ScientificName)
                .IsRequired();

            builder.HasOne(mg => mg.MuscleGroupType)
                .WithMany(mgt => mgt.MuscleGroups)
                .HasForeignKey(mg => mg.MuscleGroupTypeId);
        }
    }
}
