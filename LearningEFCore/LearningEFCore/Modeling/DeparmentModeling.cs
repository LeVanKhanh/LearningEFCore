using LearningEFCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearningEFCore.Modeling
{
    public class DeparmentModeling : IEntityTypeConfiguration<Deparment>
    {
        public void Configure(EntityTypeBuilder<Deparment> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
        }
    }
}
