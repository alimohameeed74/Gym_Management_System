using Gym_Management_System.Entities.Classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gym_Management_System.Configurations
{
    public class TrainerConfiguration : GymUserConfiguration<Trainer>, IEntityTypeConfiguration<Trainer>
    {
        public new void Configure(EntityTypeBuilder<Trainer> builder)
        {
            base.Configure(builder);
            builder.Property(B => B.HireDate).HasDefaultValueSql("GETDATE()");
            builder.ToTable(T =>
            {
                T.HasCheckConstraint("SpecializationValues", "Specialization in ('StrengthTraining','Yoga','Nutrition')");
            });
        } 
    }
}
