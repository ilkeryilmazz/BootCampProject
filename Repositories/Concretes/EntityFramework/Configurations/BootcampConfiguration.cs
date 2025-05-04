using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Concretes.EntityFramework.Configurations
{
    public partial class BootcampConfiguration : IEntityTypeConfiguration<Bootcamp>
    {
        public void Configure(EntityTypeBuilder<Bootcamp> builder)
        {
            builder.ToTable("Bootcamps");

            builder.HasKey(bootcamp => bootcamp.Id);

            builder.Property(bootcamp => bootcamp.Id).HasColumnName("Id").IsRequired();
            builder.Property(bootcamp => bootcamp.InstructorId).HasColumnName("InstructorId").IsRequired();
            builder.Property(bootcamp => bootcamp.StartDate).HasColumnName("StartDate").IsRequired();
            builder.Property(bootcamp => bootcamp.EndDate).HasColumnName("EndDate").IsRequired();
            builder.Property(bootcamp => bootcamp.BootcampState).HasColumnName("BootcampState").IsRequired();

            builder.HasOne(bootcamp => bootcamp.Instructor);
            
                  

        }

    }
}