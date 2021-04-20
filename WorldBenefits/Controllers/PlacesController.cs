using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorldBenefits.Controllers
{
    public class PlacesController : Controller
    {
        // GET: PlacesController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PlacesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PlacesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PlacesController/Create
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

        // GET: PlacesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PlacesController/Edit/5
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

        // GET: PlacesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PlacesController/Delete/5
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

        public ActionResult Places()
        {
            return View();
        }
    }
}
