using NetTopologySuite.Geometries;
using System.Collections.Generic;

namespace TopoApp.Models
{
    public class RegionModel
    {
        public int RegionID { get; set; }
        public string RegionName { get; set; }
        public Polygon RegionLoc { get; set; }
        public AreaModel Area { get; set; }
        public ICollection<SectorModel> Sectors { get; set; }
    }
}
