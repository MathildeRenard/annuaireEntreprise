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
        public IActionResult Index(string message)
        {
            ViewData["firstnameSession"] = HttpContext.Session.GetString("firstname");
            ViewData["lastnameSession"] = HttpContext.Session.GetString("lastname");
            ViewData["isLogged"] = HttpContext.Session.GetString("isLogged");

            //message pour erreur de suppression
            ViewData["message"] = message;
            Site site = new Site();
           
            return View(site.GetSites());
        }

        public ActionResult Update(String ville,int id,string message)

        {
            ViewData["message"] = message;
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
            //s'il ya eu une erreur
            if (ville == null)
            {// envoyer actualliser le message dans la vue

                return RedirectToAction("Update", "Site", new { message = "sasie incorrecte", id = id });
            }
            else
            {
                Site site = new Site();
                site.Update(ville, id);
                return RedirectToAction("Index", "Site");
            }
           
        }
        public ActionResult Add(string message)

        {
            ViewData["message"] = message;
            //variables de sessions envoyée au layout(NavBar)
            ViewData["firstnameSession"] = HttpContext.Session.GetString("firstname");
            ViewData["lastnameSession"] = HttpContext.Session.GetString("lastname");
            ViewData["isLogged"] = HttpContext.Session.GetString("isLogged");
            return View();

        }
        public ActionResult sendNew(string ville)

        {
            //s'il ya eu une erreur
            if (ville != null)
            {
                Site site = new Site();
                site.Create(ville);
                return RedirectToAction("Index", "Site");
            }
            else
            {
                return RedirectToAction("Add", "Site", new { message = "sasie incorrecte" });
            }
           

        }
        public ActionResult Delete(int id)

        {
            Site site = new Site();
            bool result = site.Delete(id);
            if (result == true)
            {
                return RedirectToAction("Index", "Site", new { message = "Vous ne pouvez pas supprimer ce site car des personnes y sont affiliées." });
            }
            return RedirectToAction("Index", "Site");

        }

    }
    }

