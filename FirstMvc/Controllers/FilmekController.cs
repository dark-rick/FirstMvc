using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstMvc.Models;
using FirstMvc.ViewModels;

namespace FirstMvc.Controllers
{
    public class FilmekController : Controller
    {
        // GET: Filmek
        public ActionResult Random()
        {


            var film = new Film() { Cim = "Kill Bill" };

            //ViewData["Film"] = film;
            //ViewBag.Film = film;

            var kolcsonzok = new List<Kolcsonzok>()
            {
                //new Kolcsonzok() {Nev = "Géza"},
                //new Kolcsonzok() {Nev = "Laci"},
                //new Kolcsonzok() {Nev = "Anna"}
            };

            var rfvm = new RandomFilmViewModel()
            {
                Film = film,
                Kolcsonzok = kolcsonzok
            };

            return View(rfvm);

            

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

        
        public ActionResult Megjelenes(int? ev, int? honap)
        {
            return Content($"év = {ev} | hónap = {honap}");
        }
    }
}