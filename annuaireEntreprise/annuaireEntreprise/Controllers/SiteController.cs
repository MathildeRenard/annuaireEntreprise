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

            Site site = new Site();
           
            return View(site.GetSites());
        }


        public ActionResult Result()
        {
            return View();
        }
        public ActionResult AdminSite()
        {
            return View();
        }
        public ActionResult Update(String ville,int id)

        {
            //envoyer le nom de la ville, et l'id récupérée par le formulaire, à la vue de modification
            ViewData["ville"] = ville;
            ViewData["id"] = id;
            return View();

        }
        public ActionResult sendChanges(string ville, int id)

        {
            Site site = new Site();
            site.Update(ville, id);
            return RedirectToAction("Index","Site");
        }



    }
    }

