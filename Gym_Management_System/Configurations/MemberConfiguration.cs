using Gym_Management_System.Entities.Classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gym_Management_System.Configurations
{
    public class MemberConfiguration:GymUserConfiguration<Member>,IEntityTypeConfiguration<Member>
    {
        public new void Configure(EntityTypeBuilder<Member> builder)
        {
            base.Configure(builder);
            builder.Property(B => B.JoinDate).HasDefaultValueSql("GETDATE()");
        } 
    }
}
