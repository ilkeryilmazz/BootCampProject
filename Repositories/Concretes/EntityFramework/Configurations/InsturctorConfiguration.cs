using Core.Entities;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Concretes.EntityFramework.Configurations
{
    public partial class InsturctorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.ToTable("Instructors");

          
          

            builder.Property(instructor => instructor.Id).HasColumnName("Id").IsRequired();
            builder.Property(instructor => instructor.CompanyName).HasColumnName("CompanyName").IsRequired().HasMaxLength(100);

          



        }
    }
}