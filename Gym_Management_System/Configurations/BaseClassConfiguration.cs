using Gym_Management_System.Entities.BaseEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gym_Management_System.Configurations
{
    public class BaseClassConfiguration<T> : IEntityTypeConfiguration<T> where T : BaseClass
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(B => B.CreatedAt).HasDefaultValueSql("GETDATE()");
        }
    }
}
