using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmpDetails.Models;

namespace Employees.Controllers
{
    public class AuthorizeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User usr)
        {
            using (EmployeeEntities1 db = new EmployeeEntities1())
            {
                var user = db.Employees.Where(x => x.Username == usr.Username && x.Password == usr.Password).FirstOrDefault();
                if (user == null)
                {
                    usr.Loginerror = "Wrong username or password";
                    return RedirectToAction("Index", usr);
                }
                else
                {
                    if (usr.Username == "admin")
                    {
                        Session["user"] = usr.Username;
                        return RedirectToAction("Index", "Employee");
                    }
                    else
                    {
                        Session["user"] = usr.Username;
                        return RedirectToAction("Nuser", "Employee");
                    }
                }
            }

        }
        public ActionResult Logout()
        {
            Session["users"] = null;
            return RedirectToAction("Index", "Authorize");

        }
    }
}

