using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace DapperIdentityDemo.Controllers
{
    public class DefaultController : Controller
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        // GET: Default
        public ActionResult Index()
        {
            try
            {
                logger.Info("Hi i am in index");

                var name = "nkosana";
                ValidateStudent(name);
                return View();
            }
            catch (System.Exception ex)
            {

                throw;
            }
        }
        private static void ValidateStudent(string studentName)
        {
            Regex regex = new Regex("^[a - zA - Z] +$");
            if (!regex.IsMatch(studentName))
                throw new Exception(studentName);
        }

        // GET: Default/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Default/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Default/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Default/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Default/Edit/5
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

        // GET: Default/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Default/Delete/5
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
