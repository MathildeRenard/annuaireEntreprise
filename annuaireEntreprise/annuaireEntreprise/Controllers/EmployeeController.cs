using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace annuaireEntreprise.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: EmployeesController1
        public ActionResult Index()
        {
            return View();
        }


        // GET: EmployeesController1/Create
        public ActionResult Search()
        {
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
