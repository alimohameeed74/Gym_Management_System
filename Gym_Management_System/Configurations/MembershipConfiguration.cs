using Gym_Management_System.Entities.Classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gym_Management_System.Configurations
{
    public class MembershipConfiguration : IEntityTypeConfiguration<Membership>
    {
        public void Configure(EntityTypeBuilder<Membership> builder)
        {
            builder.Property(B => B.StartDate).HasDefaultValueSql("GETDATE()");
            builder.ToTable(T =>
            {
                T.HasCheckConstraint("EndDateValues", "EndDate > StartDate");

            });
            builder.HasOne(B => B.Member)
                .WithMany(M => M.Memberships)
                .HasForeignKey(B => B.MemberId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(B => B.Plan)
                .WithMany(P => P.Memberships)
                .HasForeignKey(B => B.PlanId)
                .OnDelete(DeleteBehavior.Restrict);

    }
    }
}
