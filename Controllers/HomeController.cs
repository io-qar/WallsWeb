using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WallsWeb.Models;

namespace WallsWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //model
            return View();
        }

        public ActionResult About()
        {
            Comment comment = new Comment();
            comment.Text = "sdfdsfds";
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}