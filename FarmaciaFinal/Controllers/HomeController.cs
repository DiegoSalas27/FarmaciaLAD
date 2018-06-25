using FarmaciaFinal.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FarmaciaFinal.Controllers
{
    public class HomeController : Controller
    {

        public HomeController() { }

        public ActionResult Index()
        {
            ViewBag.userid = User.Identity.GetUserId();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Somos una empresa que apunta a brindar el mejor servicio de delivery de medicamentos.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Puede contactarse con nosotros por los siguientes medios:";

            return View();
        }
    }
}