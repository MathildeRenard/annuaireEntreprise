using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using annuaireEntreprise.Models;

namespace annuaireEntreprise.Controllers
{
    public class ServiceController : Controller
    {
        // GET: ServiceController1
        public IActionResult Index()
        {
            ViewData["firstnameSession"] = HttpContext.Session.GetString("firstname");
            ViewData["lastnameSession"] = HttpContext.Session.GetString("lastname");
            ViewData["isLogged"] = HttpContext.Session.GetString("isLogged");
            Service service = new Service();

            return View(service.GetServices());
        }


        public ActionResult Add()

        {
            ViewData["firstnameSession"] = HttpContext.Session.GetString("firstname");
            ViewData["lastnameSession"] = HttpContext.Session.GetString("lastname");
            ViewData["isLogged"] = HttpContext.Session.GetString("isLogged");
            return View();

        }
        public ActionResult sendNew(string nomservice)

        {
            Service service = new Service();
            service.Create(nomservice);
            return RedirectToAction("Index", "Service");

        }
        //envoyer le nom du service, et l'id récupérée par le formulaire, à la vue de modification
        public ActionResult Update(String nameservice, int id)

        {
            ViewData["firstnameSession"] = HttpContext.Session.GetString("firstname");
            ViewData["lastnameSession"] = HttpContext.Session.GetString("lastname");
            ViewData["isLogged"] = HttpContext.Session.GetString("isLogged");

            ViewData["service"] = nameservice;
            ViewData["id"] = id;
            return View();

        }
        //envoyer les modifications à la méthode update
        public ActionResult sendChanges(string nameservice, int id)

        {
            Service service = new Service();
            service.Update(nameservice, id);
            return RedirectToAction("Index", "Service");
        }
        public ActionResult Delete(int id)

        {
            Service service = new Service();
            service.Delete(id);
            return RedirectToAction("Index", "Service");

        }
    }
    }

