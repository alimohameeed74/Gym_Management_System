using Gym_Management_System.Entities.Classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gym_Management_System.Configurations
{
    public class PlanConfiguration : IEntityTypeConfiguration<Plan>
    {
        public void Configure(EntityTypeBuilder<Plan> builder)
        {
            builder.Property(B => B.Name).HasColumnType("varchar").HasMaxLength(30);
            builder.Property(B => B.Description).HasColumnType("varchar").HasMaxLength(100);
            builder.ToTable(T =>
            {
                T.HasCheckConstraint("DurationDaysValues", "DurationDays between 1 and 365");
            });
        }
    }
}
