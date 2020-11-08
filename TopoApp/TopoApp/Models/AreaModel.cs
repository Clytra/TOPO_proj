using NetTopologySuite.Geometries;
using System.Collections.Generic;

namespace TopoApp.Models
{
    public class AreaModel
    {
        public int AreaID { get; set; }
        public string AreaName { get; set; }
        public Polygon AreaLoc { get; set; }
        public ICollection<RegionModel> Regions { get; set; }
    }
}
