using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GRM_APP.Models;

namespace GRM_APP.Controllers
{

    public class CompanyInputController : Controller
    {
        //
        // GET: /CompanyInput/
        
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Poruka = "Unesi kompaniju";
            return View("CompanyInput");
        }

        [HttpPost]
        public ActionResult Index(string Name, string About, string Logo, string Address, string Phone)
        {
            using (GeneralManager manager = new GeneralManager())
            {
                manager.AddCompany(Name, About, Logo, Address, Phone);
            }

            ViewBag.Poruka = "Uspjesno ste unijeli kompaniju";              
   
            return View("CompanyInput");
        }

       

    }
}
