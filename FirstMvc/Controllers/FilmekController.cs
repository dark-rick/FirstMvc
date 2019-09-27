using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstMvc.Models;

namespace FirstMvc.Controllers
{
    public class FilmekController : Controller
    {
        // GET: Filmek
        public ActionResult Random()
        {


            var film = new Film() { Cim = "Kill Bill" };
            return View(film);
            //return Content("Szeretem a cicákat");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index","Home", new {oldal = 1, rendezes = "cica" });

        }

        public ActionResult Szerkesztes(int id)
        {
            return Content($"id = {id}");
        }

        public ActionResult Index(int? oldal = 1, string rendezes = "cím")
        {
            /*if (!oldal.HasValue)
                oldal = 1;
            if (string.IsNullOrWhiteSpace(rendezes))
                rendezes = "cim";*/

            return Content($"oldalszám:  = {oldal} | rendezés: {rendezes}");
        }

        public ActionResult MegjelenesSzerint(int ev, int honap)
        {
            return Content($"év = {ev} | hónap = {honap}");
        }
    }
}