using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TopoApp.Models
{
    public interface IClimbingRepository
    {
        IQueryable<AreaModel> Areas { get; }

        IQueryable<RegionModel> Regions { get; }
        IQueryable<SectorModel> Sectors { get; }
        IQueryable<RockModel> Rocks { get; }
        IQueryable<ClimbingRouteModel> ClimbingRoutes { get; }
    }
}
