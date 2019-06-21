using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmpDetails.Models;

namespace EmpDetails.Controllers
{
    public class EmployeeController : Controller
    {
        private EmployeeEntities1 db = new EmployeeEntities1();

        //
        // GET: /Employee/

        public ActionResult Index()
        {
            var employees = db.Employees.Include(e => e.Dept).Include(e => e.EmpRole);
            return View(employees.ToList());
        }

        //
        // GET: /Employee/Details/5

        public ActionResult Details(int id = 0)
        {
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        //
        // GET: /Employee/Create

        public ActionResult Create()
        {
            ViewBag.Dept_ID = new SelectList(db.Depts, "Dept_ID", "Department_Name");
            ViewBag.Role_ID = new SelectList(db.EmpRoles, "Role_ID", "Role_Name");
            return View();
        }

        //
        // POST: /Employee/Create

        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Employees.Add(employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Dept_ID = new SelectList(db.Depts, "Dept_ID", "Department_Name", employee.Dept_ID);
            ViewBag.Role_ID = new SelectList(db.EmpRoles, "Role_ID", "Role_Name", employee.Role_ID);
            return View(employee);
        }

        //
        // GET: /Employee/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            ViewBag.Dept_ID = new SelectList(db.Depts, "Dept_ID", "Department_Name", employee.Dept_ID);
            ViewBag.Role_ID = new SelectList(db.EmpRoles, "Role_ID", "Role_Name", employee.Role_ID);
            return View(employee);
        }

        //
        // POST: /Employee/Edit/5

        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Dept_ID = new SelectList(db.Depts, "Dept_ID", "Department_Name", employee.Dept_ID);
            ViewBag.Role_ID = new SelectList(db.EmpRoles, "Role_ID", "Role_Name", employee.Role_ID);
            return View(employee);
        }

        //
        // GET: /Employee/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        //
        // POST: /Employee/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Employee employee = db.Employees.Find(id);
            db.Employees.Remove(employee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}