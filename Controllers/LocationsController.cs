﻿using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers
{
    public class LocationsController : Controller
    {
        // GET: LocationsController
        public ActionResult Index()
        {
            using (PizzeriaContext db = new PizzeriaContext())
            {
                List<Location> locationsList = db.Locations.ToList<Location>();
                return View(locationsList);
            }
        }

        // GET: LocationsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LocationsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LocationsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LocationsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LocationsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LocationsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LocationsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
