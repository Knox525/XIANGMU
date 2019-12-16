using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Filters;
using WebApplication.Models;
using WebApplication1.Models;

namespace WebApplication.Controllers
{
    [RequireAuthentication]
    [ActionResultExceptionFilter]
    public class HomeController : Controller
        
    {

private lclEntities db = new lclEntities();
        public ActionResult Index()
        {

            var sidebars = db.SideBars.ToList();
            ViewBag.SideBars = sidebars;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [ChildActionOnly]
        public ActionResult Navbar()
        {
            var site = new WebsiteInfo();
            ViewBag.Site = site;
            return PartialView("~/Views/Shared/Navbar.cshtml");
        }
        public ActionResult SideBar()
        {
           var sidebars = db.SideBars.ToList();
            ViewBag.SideBars = sidebars;
            return PartialView("~/Views/Shared/SideBar.cshtml");
       }
    }
}