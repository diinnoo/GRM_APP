using GRM_APP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GRM_APP.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        [HttpGet]
        public ActionResult Index()
        {

            return View();
        }

        //[HttpPost]
        //public string nesto(string nesto)
        //{
        //    return nesto;
        //}

    }
}
