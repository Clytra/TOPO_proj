using System.Collections.Generic;
using System.Linq;

namespace TopoApp.Models
{
    public class FakeClimbingRepository : IClimbingRepository
    {
        public IQueryable<AreaModel> Areas => new List<AreaModel>
        {
            new AreaModel {AreaID = 1, AreaName = "Jura Krakowsko-Częstochowska", 
                AreaLoc = null, Regions = Regions.ToList()}
        }.AsQueryable<AreaModel>();

        public IQueryable<RegionModel> Regions => new List<RegionModel>
        {
            new RegionModel {RegionID = 1, RegionName = "Dolina Będkowska",
                RegionLoc = null, Sectors = Sectors.ToList()}
        }.AsQueryable<RegionModel>();

        public IQueryable<SectorModel> Sectors => new List<SectorModel>
        {
            new SectorModel {SectorID = 1, SectorName = "Czarcie Wrota", 
                SectorLoc = null, Rocks = Rocks.ToList()}
        }.AsQueryable<SectorModel>();

        public IQueryable<RockModel> Rocks => new List<RockModel>
        {
            new RockModel {RockID = 1, RockName = "Czarcie Wrota", 
                RockLoc = null, RockType = "Wapień", NumOfRoutes = 20,
                ChildrenFriendly = false, MinHight = 14, MaxHight = 24, ClimbingRoutes = ClimbingRoutes.ToList()}
        }.AsQueryable<RockModel>();

        public IQueryable<ClimbingRouteModel> ClimbingRoutes => new List<ClimbingRouteModel>
        {
            new ClimbingRouteModel {ClimbingRouteID = 1, ClimbingRouteName = "Rysa Kurtyki",
                ClimbingRouteLoc = null, ClimbingGrade = "VI.2+", Assurance = "8r + ST",
                Author = "B. Kaleta", YearFrom = 1986, Length = 18}
        }.AsQueryable<ClimbingRouteModel>();
    }
}
