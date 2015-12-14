using GRM_APP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GRM_APP.Controllers
{
    public class CompanyOutputController : Controller
    {
        //
        // GET: /CompanyOutput/

        public ActionResult ListOfCompanies()
        {
            

            List<Company> companyList;
            using (GeneralManager manager = new GeneralManager())
            {
                companyList = manager.TopNineCompanies();
            }
            return View(companyList);

            

        }

    }
}
