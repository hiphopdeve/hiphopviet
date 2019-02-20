using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebHipHop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult News()
        {
            return View();
        }

        public ActionResult Top100()
        {
            return View();
        }

        public ActionResult Songs()
        {
            return View();
        }

        public ActionResult SongDetail()
        {
            return View();
        }
        public ActionResult Mixtapes()
        {
            return View();
        }

        public ActionResult Videos()
        {
            return View();
        }

        public ActionResult VideoDetail()
        {
            return View();
        }

        public ActionResult Artists()
        {
            return View();
        }

        public ActionResult ArtistDetail()
        {
            return View();
        }

    }
}