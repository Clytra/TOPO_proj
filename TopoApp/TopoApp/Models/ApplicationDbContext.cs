using Microsoft.EntityFrameworkCore;

namespace TopoApp.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<AreaModel> Areas { get; set; }
        public DbSet<RegionModel> Regions { get; set; }
        public DbSet<SectorModel> Sectors { get; set; }
        public DbSet<RockModel> Rocks { get; set; }
        public DbSet<ClimbingRouteModel> ClimgingRoutes { get; set; }
    }
}
