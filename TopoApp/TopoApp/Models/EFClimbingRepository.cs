using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TopoApp.Models
{
    public class EFClimbingRepository : IClimbingRepository
    {
        private ApplicationDbContext _context;
        public EFClimbingRepository(ApplicationDbContext ctx)
        {
            _context = ctx;
        }
        public IQueryable<AreaModel> Areas => _context.Areas;

        public IQueryable<RegionModel> Regions => _context.Regions;

        public IQueryable<SectorModel> Sectors => _context.Sectors;

        public IQueryable<RockModel> Rocks => _context.Rocks;

        public IQueryable<ClimbingRouteModel> ClimbingRoutes => _context.ClimgingRoutes;
    }
}
