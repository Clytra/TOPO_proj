using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TopoApp.Models
{
    public class RegionModel
    {
        public int RegionID { get; set; }
        public string RegionName { get; set; }
        public Polygon RegionLoc { get; set; }
    }
}
