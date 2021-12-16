using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace annuaireEntreprise.Controllers
{
    public class ServiceController : Controller
    {
        // GET: ServiceController1
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Result()
        {
            return View();
        }

        public ActionResult AdminService()
        {
            return View();
        }
    }
    }

