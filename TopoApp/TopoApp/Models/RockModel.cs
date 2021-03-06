﻿using NetTopologySuite.Geometries;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TopoApp.Models
{
    public class RockModel
    {
        [Key]
        public int RockID { get; set; }
        public string RockName { get; set; }
        public string RockType { get; set; }
        public int NumOfRoutes { get; set; }
        public double MinHight { get; set; }
        public double MaxHight { get; set; }
        public bool ChildrenFriendly { get; set; }
        public Point RockLoc { get; set; }
        public SectorModel Sector { get; set; }
        public ICollection<ClimbingRouteModel> ClimbingRoutes { get; set; }
    }
}
