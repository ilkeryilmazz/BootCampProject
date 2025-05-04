using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Concretes.EntityFramework.Configurations
{
    public partial class ApplicantConfiguration
    {
        public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
        {
            public void Configure(EntityTypeBuilder<Employee> builder)
            {
                builder.ToTable("Employees");

           

                builder.Property(employee => employee.Id).HasColumnName("Id").IsRequired();
                builder.Property(employee => employee.Position).HasColumnName("Position").IsRequired().HasMaxLength(125);

            }
        }
    }
}