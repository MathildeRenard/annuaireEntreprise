using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using annuaireEntreprise.Models;
using annuaireEntreprise.ViewModels;

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
            ViewData["isLogged"] = null;

            return View(employee.GetEmployees());
        }

        public ActionResult Update(String firstname, string lastname, int phone, int mobilePhone, string mail, string service, string site, int idEmployee, int idservice, int idsite)

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
            Employee employee= new Employee();
            employee.Update(firstname,lastname, phone, mobilePhone, mail, idEmployee, idservice, idsite);
            return RedirectToAction("Index", "Employee");
        }
        public ActionResult Add()
        {
            //variables de sessions envoyée au layout(NavBar)
            ViewData["firstnameSession"] = HttpContext.Session.GetString("firstname");
            ViewData["lastnameSession"] = HttpContext.Session.GetString("lastname");
            ViewData["isLogged"] = HttpContext.Session.GetString("isLogged");

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
            Employee employee = new Employee();
            employee.Create(firstname, lastname, phone, mobilePhone, mail, idEmployee, idservice, idsite);
            return RedirectToAction("Index", "Employee");
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
            Employee employee = new Employee();
            Employee result = employee.Login(mail, password);
            if (result != null)
            {
                HttpContext.Session.SetString("firstname", result.Firstname);
                HttpContext.Session.SetString("lastname", result.Lastname);
                HttpContext.Session.SetString("isLogged", "true");
            }

            return RedirectToAction("Index", "Home");
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Logout()
        {
            //HttpContext.Session.clear();
            return View();
        }
        public ActionResult Result()
        {
            return View();
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
