using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SignalR_LiveChat.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "LiveChat mit SignalR für ein Schulprojekt im Fach Netzwerksysteme";

            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Chat()
        {
            return View();
        }
    }
}