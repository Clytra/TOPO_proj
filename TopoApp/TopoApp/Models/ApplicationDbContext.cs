using Microsoft.EntityFrameworkCore;
using NetTopologySuite;

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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var geometryFactory = NtsGeometryServices.Instance.CreateGeometryFactory(srid: 3857);

            modelBuilder.Entity<AreaModel>()
                .Property(x => x.AreaLoc).HasColumnType("geometry");
            modelBuilder.Entity<RegionModel>()
                .Property(x => x.RegionLoc).HasColumnType("geometry");
            modelBuilder.Entity<RockModel>()
                .Property(x => x.RockLoc).HasColumnType("geometry");
        }
    }
}
