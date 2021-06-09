using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WallsWeb.Models;

namespace WallsWeb.Controllers
{
    public class WallsController : Controller
    {
        // GET: Walls
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Wall(int id)
        {
            WallManager wallManager = new WallManager();
            var wall = wallManager.GetWall(1);
            return View(wall);
        }
    }
}
