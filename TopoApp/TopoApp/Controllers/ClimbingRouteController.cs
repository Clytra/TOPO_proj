using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TopoApp.Models;

namespace TopoApp.Controllers
{
    public class ClimbingRouteController : Controller
    {
        private IClimbingRepository repository;
        public ClimbingRouteController(IClimbingRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index() => View(); 
        public ViewResult List() => View(repository.Areas);
    }
}