using Core.Entities;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Repositories.Concretes.EntityFramework.Configurations
{
    public partial class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(user => user.Id);

            builder.Property(user => user.Id).HasColumnName("Id").IsRequired();
            builder.Property(user => user.FirstName).HasColumnName("FirstName").IsRequired().HasMaxLength(50);
            builder.Property(user => user.LastName).HasColumnName("LastName").IsRequired().HasMaxLength(50);
            builder.Property(user => user.DateOfBirth).HasColumnName("DateOfBirth").IsRequired();
            builder.Property(user => user.Email).HasColumnName("Email").IsRequired();
            builder.Property(user => user.Password).HasColumnName("Password").IsRequired().HasMaxLength(24);
          

        }
    }
}