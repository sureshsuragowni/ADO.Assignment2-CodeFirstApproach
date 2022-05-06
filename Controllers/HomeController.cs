using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusInfoCodeFirst.Models;

namespace BusInfoCodeFirst.Controllers
{
    public class HomeController : Controller
    {
       BusInfoContext context=new BusInfoContext();
        public ActionResult Index()
        {
            return View(context.BusInfo);
        }

       public ActionResult AddBus()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SaveBus(BusInfo Bus)
        {
            context.BusInfo.Add(Bus);
            context.SaveChanges();
            return RedirectToAction("Index");
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
    }
}