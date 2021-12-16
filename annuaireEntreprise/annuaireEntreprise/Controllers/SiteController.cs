using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace annuaireEntreprise.Controllers
{
    public class SiteController : Controller
    {
        // GET: SiteController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Result()
        {
            return View();
        }
        public ActionResult AdminSite()
        {
            return View();
        }
        public ActionResult Add()
        {
            return View();
        }


    }
    }

