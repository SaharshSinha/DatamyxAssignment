using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business.Entities;
using Business.Processes;

namespace Web.Controllers
{
    public class EmployeesController : BaseController
    {

        EmployeeProcesses employeeProcesses = new EmployeeProcesses();
        //
        // GET: /Employees/

        public ActionResult Index()
        {
            return View(dataBase.Employees);
        }

        //
        // GET: /Employees/Details/5

        public ActionResult Details(int id)
        {
            return View(dataBase.Employees.Find(id));
        }

        //
        // GET: /Employees/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Employees/Create

        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            try
            {
                var successful = employeeProcesses.AddEmployee(employee);
                if (!successful) return RedirectToAction("Exception"); 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Employees/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Employees/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Employees/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Employees/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
