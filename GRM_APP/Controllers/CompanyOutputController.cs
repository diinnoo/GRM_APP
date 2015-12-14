using GRM_APP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GRM_APP.Models;

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

        public ActionResult ReturnCompany(int id)
        {

            Company company = new Company();
            using (GeneralManager manager = new GeneralManager())
            {
                company = manager.returnCompany(id);
                if (company != null)
                {
                    manager.IncreasePopularity(company);
                }
                
            }

            return View(company);
        }


    }
}
