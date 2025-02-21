using Demo.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Configurations
{
    internal class EmployeeConfigurations : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(E=>E.Id).UseIdentityColumn(10,10);
            
            builder.Property(E => E.Name)
                   .HasColumnName("EmpName")
                   .HasColumnType("nvarchar")
                   .HasMaxLength(50);

            builder.Property(E => E.Salary)
                   .HasColumnType("money");

            builder.Property(E => E.Address)
                   .HasColumnType("nvarchar")
                   .HasMaxLength(50);
            builder.HasOne(E => E.WorkFor)
                   .WithMany(D => D.Employees)
                   .HasForeignKey(E => E.DeptId);
        }
    }
}
