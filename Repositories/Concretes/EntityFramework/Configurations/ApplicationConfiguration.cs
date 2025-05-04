using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Repositories.Concretes.EntityFramework.Configurations
{
    public partial class BlacklistConfiguration
    {
        public partial class ApplicationConfiguration : IEntityTypeConfiguration<Application>
        {
            public void Configure(EntityTypeBuilder<Application> builder)
            {
                builder.ToTable("Applications");

                builder.HasKey(application => application.Id);

                builder.Property(application => application.Id).HasColumnName("Id").IsRequired();
                builder.Property(application => application.ApplicantId).HasColumnName("ApplicantId").IsRequired();
                builder.Property(application => application.BootcampId).HasColumnName("BootcampId").IsRequired();
                builder.Property(application => application.ApplicationState).HasColumnName("ApplicationState").IsRequired();

              
                builder.HasOne(application => application.Bootcamp)
                       .WithMany()
                       .HasForeignKey(application => application.BootcampId)
                       .OnDelete(DeleteBehavior.Cascade);


                builder.HasOne(application => application.Applicant)
                       .WithMany()
                       .HasForeignKey(application => application.ApplicantId)
                       .OnDelete(DeleteBehavior.Restrict);
            }

        }
    }
}