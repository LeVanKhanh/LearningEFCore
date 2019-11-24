using LearningEFCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningEFCore.Modeling
{
    public class EmployeeDeparmentModeling : IEntityTypeConfiguration<EmployeeDeparment>
    {
        public void Configure(EntityTypeBuilder<EmployeeDeparment> builder)
        {
            builder.HasKey(p => new { p.EmployeeId, p.DepartmentId });
            builder.HasOne(p => p.Deparment)
                .WithMany(p => p.EmployeeDeparments)
                .HasForeignKey(p => p.DepartmentId);
        }
    }
}
