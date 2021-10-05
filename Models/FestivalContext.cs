using Microsoft.EntityFrameworkCore;

namespace Festival.Models
{
  public class FestivalContext : DbContext
  {
    public DbSet<Artist> Artists { get; set; }
    public DbSet<Stage> Stages { get; set; }

    public FestivalContext(DbContextOptions options) : base(options) { }
    protected override void OnConfiguring(DbContextOptionsbuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}