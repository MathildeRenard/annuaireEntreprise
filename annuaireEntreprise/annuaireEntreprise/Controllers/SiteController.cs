using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using annuaireEntreprise.Models;

namespace annuaireEntreprise.Controllers
{
    public class SiteController : Controller
    {
        // GET: SiteController
        public IActionResult Index()
        {
            ViewData["firstnameSession"] = HttpContext.Session.GetString("firstname");
            ViewData["lastnameSession"] = HttpContext.Session.GetString("lastname");
            ViewData["isLogged"] = HttpContext.Session.GetString("isLogged");
            Site site = new Site();
           
            return View(site.GetSites());
        }

        public ActionResult Update(String ville,int id)

        {
            //envoyer le nom de la ville, et l'id récupérée par le formulaire, à la vue de modification
            ViewData["ville"] = ville;
            ViewData["id"] = id;

            //variables de sessions envoyée au layout(NavBar)
            ViewData["firstnameSession"] = HttpContext.Session.GetString("firstname");
            ViewData["lastnameSession"] = HttpContext.Session.GetString("lastname");
            ViewData["isLogged"] = HttpContext.Session.GetString("isLogged");

            return View();

        }
        public ActionResult sendChanges(string ville, int id)

        {
            Site site = new Site();
            site.Update(ville, id);
            return RedirectToAction("Index","Site");
        }
        public ActionResult Add()

        {
            //variables de sessions envoyée au layout(NavBar)
            ViewData["firstnameSession"] = HttpContext.Session.GetString("firstname");
            ViewData["lastnameSession"] = HttpContext.Session.GetString("lastname");
            ViewData["isLogged"] = HttpContext.Session.GetString("isLogged");
            return View();

        }
        public ActionResult sendNew(string ville)

        {
            Site site = new Site();
            site.Create(ville);
            return RedirectToAction("Index", "Site");

        }
        public ActionResult Delete(int id)

        {
            Site site = new Site();
            site.Delete(id);
            return RedirectToAction("Index", "Site");

        }

    }
    }

