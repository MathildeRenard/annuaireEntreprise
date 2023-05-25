using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using annuaireEntreprise.Models;
using annuaireEntreprise.ViewModels;
using Microsoft.Extensions.Caching.Distributed;

namespace annuaireEntreprise.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: EmployeesController1
        public IActionResult Index()
        {

            Employee employee = new Employee();
            //variables de sessions envoyée au layout(NavBar)
            ViewData["firstnameSession"] = HttpContext.Session.GetString("firstname");
            ViewData["lastnameSession"] = HttpContext.Session.GetString("lastname");
            ViewData["isLogged"] = HttpContext.Session.GetString("isLogged"); ;

            return View(employee.GetEmployees());
        }
        private readonly IDistributedCache _cache;

        public EmployeeController(IDistributedCache cache)
        {
            _cache = cache;
        }
        public ActionResult Update(String firstname, string lastname, int phone, int mobilePhone, string mail, string service, string site, int idEmployee, int idservice, int idsite,string message)

        {
            //envoyer le nom de la ville, et l'id récupérée par le formulaire, à la vue de modification
            ViewData["firstname"] = firstname;
            ViewData["lastname"] = lastname;
            ViewData["phone"] = phone;
            ViewData["mobilePhone"] = mobilePhone;
            ViewData["mail"] = mail;
            ViewData["service"] = service;
            ViewData["site"] = site;
            ViewData["idEmployee"] = idEmployee;
            ViewData["idsite"] = idsite;
            ViewData["idservice"] = idservice;

            ViewData["message"] = message;

            //variables de sessions envoyée au layout(NavBar)
            ViewData["firstnameSession"] = HttpContext.Session.GetString("firstname");
            ViewData["lastnameSession"] = HttpContext.Session.GetString("lastname");
            ViewData["isLogged"] = HttpContext.Session.GetString("isLogged");

            Site siteListe = new Site();
            Service serviceListe = new Service();
            ViewModelEmployee viewModelEmployee = new ViewModelEmployee()
            {
                listeSites = siteListe.GetSites(),
                listeServices = serviceListe.GetServices()
            }; 
           return View(viewModelEmployee);
    
        }

        public ActionResult sendChanges(String firstname, string lastname, int phone, int mobilePhone, string mail, string service, string site, int idEmployee, int idservice, int idsite)

        {

            //s'il ya eu une erreur
            if (firstname == null|lastname==null|phone==0|mobilePhone==0|mail==null)
            {// envoyer actualliser le message dans la vue

                return RedirectToAction("Update", "Employee", new { message = "sasie incorrecte", idEmployee = idEmployee });
            }
            else
            {
                Employee employee = new Employee();
                employee.Update(firstname, lastname, phone, mobilePhone, mail, idEmployee, idservice, idsite);
                return RedirectToAction("Index", "Employee");
            }

            
        }
        public ActionResult Add(string message)
        {
            //variables de sessions envoyée au layout(NavBar)
            ViewData["firstnameSession"] = HttpContext.Session.GetString("firstname");
            ViewData["lastnameSession"] = HttpContext.Session.GetString("lastname");
            ViewData["isLogged"] = HttpContext.Session.GetString("isLogged");

            ViewData["message"] = message;
            //envoyer les informations pour remplir les input avec liste déroulante
            Site siteListe = new Site();
            Service serviceListe = new Service();
            ViewModelEmployee viewModelEmployee = new ViewModelEmployee()
            {
                listeSites = siteListe.GetSites(),
                listeServices = serviceListe.GetServices()
            };
            return View(viewModelEmployee);
        }
        public ActionResult sendnew(String firstname, string lastname, int phone, int mobilePhone, string mail, string service, string site, int idEmployee, int idservice, int idsite)

        {

            //s'il ya eu une erreur
            if (firstname == null | lastname == null | phone == 0 | mobilePhone == 0 | mail == null)
            {
                
                return RedirectToAction("Add", "Employee", new { message = "sasie incorrecte" });
            }
            else
            {
                Employee employee = new Employee();
                employee.Create(firstname, lastname, phone, mobilePhone, mail, idEmployee, idservice, idsite);
                return RedirectToAction("Index", "Employee");
            }
       
        }

        public ActionResult Delete(int idEmployee)

        {
            Employee employee = new Employee();
            employee.Delete(idEmployee);
            return RedirectToAction("Index", "Employee");

        }
        // GET: EmployeesController1/Create
        public ActionResult SendLogin(string mail,string password)
        {
            string ip = HttpContext.Connection.RemoteIpAddress.ToString();

            var cacheEntry = _cache.GetString(ip);

            int attemptCount = cacheEntry == null ? 0 : int.Parse(cacheEntry);

            // Limit to 5 attempts every 15 minutes, for example
            if (attemptCount >= 5)
            {
                return RedirectToAction("Login", "Employee", new { message = "Trop de tentatives de connexion. Veuillez réessayer ultérieurement." });
            }

            Employee employee = new Employee();
            Employee result = employee.Login(mail, password);

            if (result != null)
            {
                HttpContext.Session.SetString("firstname", result.Firstname);
                HttpContext.Session.SetString("lastname", result.Lastname);
                HttpContext.Session.SetString("isLogged", "true");
            }
            else
            {
                _cache.SetString(ip, (++attemptCount).ToString(), new DistributedCacheEntryOptions
                {
                    AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(15)
                });
                return RedirectToAction("Login", "Employee", new { message = "Identifiant ou mot de passe incorrects." });
            }

            return RedirectToAction("Index", "Home");
        }

        public ActionResult Login(string message)
        {
            ViewData["message"] = message;
            return View();
        }
        public ActionResult Result()
        {
            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
        public ActionResult EmployeeSheet()
        {
            return View();
        }
        public ActionResult AdminEmployee()
        {
            return View();
        }

    }
}
