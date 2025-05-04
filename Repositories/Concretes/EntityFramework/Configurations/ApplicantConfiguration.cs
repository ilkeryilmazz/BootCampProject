using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Concretes.EntityFramework.Configurations
{
    public partial class ApplicantConfiguration : IEntityTypeConfiguration<Applicant>
    {
        public void Configure(EntityTypeBuilder<Applicant> builder)
        {
            builder.ToTable("Applicants");

           

            builder.Property(applicant => applicant.Id).HasColumnName("Id").IsRequired();
            builder.Property(applicant => applicant.About).HasColumnName("About").IsRequired().HasMaxLength(500);

            builder.HasOne(a => a.Blacklist)
         .WithOne(b => b.Applicant)
         .HasForeignKey<Blacklist>(b => b.ApplicantId)
         .OnDelete(DeleteBehavior.Cascade);


        }
    }
}