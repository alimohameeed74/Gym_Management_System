using Gym_Management_System.Entities.BaseEntities;
using Gym_Management_System.Entities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gym_Management_System.Configurations
{
    public class GymUserConfiguration<T> :BaseClassConfiguration<T> ,IEntityTypeConfiguration<T> where T : GymUser
    {
        public new void Configure(EntityTypeBuilder<T> builder)
        {
            base.Configure(builder);
            builder.Property(B => B.Name).HasColumnType("varchar").HasMaxLength(30);
            builder.Property(B => B.Email).HasColumnType("varchar").HasMaxLength(100);
            builder.Property(B => B.Phone).HasColumnType("varchar").HasMaxLength(11);
            builder.Property(B => B.DateOfBirth).HasDefaultValueSql("GETDATE()");
            builder.ComplexProperty(B => B.Address);
            builder.HasIndex(B=> B.Email).IsUnique();
            builder.HasIndex(B=> B.Phone).IsUnique();

            builder.ToTable(T =>
            {
                T.HasCheckConstraint("EmailFormat", "Email LIKE '_%@_%._%'");
                T.HasCheckConstraint("GenderValue", "Gender in ('Male','Female')");
                T.HasCheckConstraint("PhoneFormat", "LEN(Phone) = 11 and (Phone LIKE '010%' OR Phone LIKE '011%' OR Phone LIKE '012%' OR Phone LIKE '015%')");
            });


    }
    }
}
