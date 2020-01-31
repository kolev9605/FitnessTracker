using FitnessTracker.Application.Constants;
using FitnessTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitnessTracker.Persistance.Configurations
{
    public class MuscleGroupTypeConfiguration : IEntityTypeConfiguration<MuscleGroupType>
    {
        public void Configure(EntityTypeBuilder<MuscleGroupType> builder)
        {
            builder.Property(mgt => mgt.Name)
                .IsRequired();
        }
    }
}