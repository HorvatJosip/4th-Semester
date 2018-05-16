using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zadatak_1.Models;

namespace Zadatak_1.Controllers
{
    public class MojController : Controller
    {
        // GET: Moj
        public string Pozdrav(string ime)
        {
            return $"Pozdrav, {ime}!";
        }

        //public ActionResult PozdraviOsobu(string ime)
        //    => new ContentResult()
        //       {
        //           Content = $"Pozdrav osobi {ime}"
        //       };

        //public ActionResult PozdraviOsobu(string ime, string prezime)
        //{
        //    var osoba = new Osoba { Ime = ime, Prezime = prezime };

        //    return Content($"{osoba}");
        //}

        public ActionResult PozdraviOsobu(Osoba osoba)
            => Content($"{osoba}");
    }
}