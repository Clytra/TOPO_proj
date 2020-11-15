using NetTopologySuite.Geometries;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TopoApp.Models
{
    public class RegionModel
    {
        [Key]
        public int RegionID { get; set; }
        public string RegionName { get; set; }
        public Polygon RegionLoc { get; set; }
        public AreaModel Area { get; set; }
        public ICollection<SectorModel> Sectors { get; set; }
    }
}
