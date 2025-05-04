using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Repositories.Concretes.EntityFramework.Configurations
{
    public partial class BlacklistConfiguration : IEntityTypeConfiguration<Blacklist>
    {
        public void Configure(EntityTypeBuilder<Blacklist> builder)
        {
            builder.ToTable("Blacklists");

            builder.HasKey(blacklist => blacklist.Id);

            builder.Property(blacklist => blacklist.Id).HasColumnName("Id").IsRequired();
            builder.Property(blacklist => blacklist.ApplicantId).HasColumnName("ApplicantId").IsRequired();
            builder.Property(blacklist => blacklist.Reason).HasColumnName("Reason").IsRequired().HasMaxLength(500);

            builder.HasOne(blacklist => blacklist.Applicant)
       .WithOne(applicant => applicant.Blacklist)
       .HasForeignKey<Blacklist>(b => b.ApplicantId)
       .OnDelete(DeleteBehavior.Restrict); 


        }

    }
}