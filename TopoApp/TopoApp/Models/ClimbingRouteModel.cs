using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TopoApp.Models
{
    public class ClimbingRouteModel
    {
        public int ClimbingRouteID { get; set; }
        public string ClimbingRouteName { get; set; }
        public string ClimbingGrade { get; set; }
        public string Assurance { get; set; }
        public double Rating { get; set; }
        public string Author { get; set; }
        public DateTime YearFrom { get; set; }
        public DateTime YearTo { get; set; }
        public double Length { get; set; }
        public Point ClimbingRouteLoc { get; set; }
        public RockModel Rock { get; set; }
    }
}
