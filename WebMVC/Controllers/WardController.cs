﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebMVC.Controllers
{
    public class WardController : Controller
    {
        // GET: WardController
        public ActionResult Index()
        {
            return View();
        }

        // GET: WardController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: WardController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WardController/Create
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

        // GET: WardController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: WardController/Edit/5
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

        // GET: WardController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: WardController/Delete/5
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
