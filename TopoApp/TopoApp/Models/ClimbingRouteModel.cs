using NetTopologySuite.Geometries;
using System;
using System.ComponentModel.DataAnnotations;

namespace TopoApp.Models
{
    public class ClimbingRouteModel
    {
        [Key]
        public int ClimbingRouteID { get; set; }
        public string ClimbingRouteName { get; set; }
        public string ClimbingGrade { get; set; }
        public string Assurance { get; set; }
        public double Rating { get; set; }
        public string Author { get; set; }
        public int YearFrom { get; set; }
        public int YearTo { get; set; }
        public double Length { get; set; }
        public Point ClimbingRouteLoc { get; set; }
        public RockModel Rock { get; set; }
    }
}
