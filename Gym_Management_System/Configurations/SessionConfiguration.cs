using Gym_Management_System.Entities.Classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gym_Management_System.Configurations
{
    public class SessionConfiguration : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {
            builder.Property(B => B.Description).HasColumnType("varchar").HasMaxLength(100);
            builder.Property(B => B.StartDate).HasDefaultValueSql("GETDATE()");
            builder.ToTable(T =>
            {
                T.HasCheckConstraint("CapacityValues", "Capacity between 1 and 25");
                T.HasCheckConstraint("EndDateValues", "EndDate > StartDate");

            });
            builder.HasOne(B => B.Trainer)
                .WithMany(T => T.Sessions)
                .HasForeignKey(B => B.TrainerId)
                .OnDelete(DeleteBehavior.Restrict);
    }
    }
}
