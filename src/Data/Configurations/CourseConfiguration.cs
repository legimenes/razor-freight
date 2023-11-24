using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RazorFreight.Models;

namespace RazorFreight.Data.Configurations;

internal sealed class CourseConfiguration : IEntityTypeConfiguration<Course>
{
    public void Configure(EntityTypeBuilder<Course> builder)
    {
        builder.ToTable("Courses");

        builder.HasKey(p => p.Id);
        builder.Property(p => p.Id).HasColumnType("TEXT");

        builder.Property(p => p.Origin);

        builder.Property(p => p.Destination);
        
        builder.Property(p => p.DistanceInKm).HasColumnType("REAL");

        builder.HasIndex(p => new { p.Origin, p.Destination }).IsUnique().HasDatabaseName("OriginDestinationIndex");
    }
}
