using EmpDetails.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmpDetails.Controllers
{
    public class OperationsController : Controller
    {
        //
        // GET: /Operations/

     

        [HttpPost]
        public ActionResult Index1(string Name)
        {
            EmployeeEntities1 entities = new EmployeeEntities1();
            return View(entities.Customers_Search(Name));
        }
    }
}


