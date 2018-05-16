using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Zadatak_1.Controllers
{
    public class MatematikaController : Controller
    {
        // GET: Matematika
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Korijen(int broj)
        {
            if (broj > 0)
                return Content(Math.Sqrt(broj).ToString());
            else if (broj < 0)
                return RedirectToAction("Greska");
            else
                return Redirect("https://www.google.com?q=Uci%20matematiku...");
        }

        public ActionResult Greska()
            => Content("Desila se greška, broj mora biti pozitivan");
    }
}