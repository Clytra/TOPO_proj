using NetTopologySuite.Geometries;
using System.Collections.Generic;

namespace TopoApp.Models
{
    public class SectorModel
    {
        public int SectorID { get; set; }
        public string SectorName { get; set; }
        public Polygon SectorLoc { get; set; }
        public RegionModel Region { get; set; }
        public ICollection<RockModel> Rocks { get; set; }
    }
}
