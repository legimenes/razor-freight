using Microsoft.EntityFrameworkCore;

namespace RazorFreight.Data;

public sealed class RazorFreightDbContext : DbContext
{
    public RazorFreightDbContext(DbContextOptions<RazorFreightDbContext> options)
    : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);            
        optionsBuilder.LogTo(Console.WriteLine, LogLevel.Debug);
        optionsBuilder.EnableDetailedErrors();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(RazorFreightDbContext).Assembly);
    }
}
