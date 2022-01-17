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


        public ActionResult Add(string message)

        {
            ViewData["message"] = message;
            ViewData["firstnameSession"] = HttpContext.Session.GetString("firstname");
            ViewData["lastnameSession"] = HttpContext.Session.GetString("lastname");
            ViewData["isLogged"] = HttpContext.Session.GetString("isLogged");
            return View();

        }
        public ActionResult sendNew(string nomservice)

        {
            //s'il ya eu une erreur
            if (nomservice != null) { 

                Service service = new Service();
            service.Create(nomservice);
            return RedirectToAction("Index", "Service");
            }else{
                return RedirectToAction("Add", "Service", new { message = "sasie incorrecte" });
            }

        }
        //envoyer le nom du service, et l'id récupérée par le formulaire, à la vue de modification
        public ActionResult Update(String nameservice, int id,string message)

        {
             ViewData["message"] = message;

            ViewData["firstnameSession"] = HttpContext.Session.GetString("firstname");
            ViewData["lastnameSession"] = HttpContext.Session.GetString("lastname");
            ViewData["isLogged"] = HttpContext.Session.GetString("isLogged");
            ViewData["service"] = nameservice;
            ViewData["id"] = id;
            return View();

        }
      
        public ActionResult sendChanges(string nameservice, int id)

        {
            //s'il ya eu une erreur
            if (nameservice == null)
            {// envoyer actualliser le message dans la vue
                
                return RedirectToAction("Update", "Service",new { message = "sasie incorrecte"});
            }
            else
            {
                Service service = new Service();
                service.Update(nameservice, id);
                return RedirectToAction("Index", "Service");
            }
        }
        public ActionResult Delete(int id)

        {
            Service service = new Service();
            service.Delete(id);
            return RedirectToAction("Index", "Service");

        }
    }
    }

