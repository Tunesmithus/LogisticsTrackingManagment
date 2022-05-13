﻿using LogisticsManagement.AppLogic.Contracts;
using LogisticsManagement.Common.StaticUtility;
using LogisticsManagement.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LogisticsManagement.Web.Controllers
{
    public class TruckController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public TruckController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        // GET: TruckController
        public IActionResult Index()
        {
            return View();
        }


        // GET: TruckController/Create
        public ActionResult Create()
        {
            var TruckMakeList = StaticList.GetTruckMakes().Select(x => x.Text);
            ViewBag.TruckMakeList = TruckMakeList;

            var ColorList = StaticList.GetColors().Select(x => x.Text);
            ViewBag.ColorList = ColorList;

            var YearList = StaticList.GetYearList().Select(x => x.Text);
            ViewBag.YearList = YearList;

            return View();
        }

        // POST: TruckController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Truck truck)
        {
            if (ModelState.IsValid == true)
            {
                unitOfWork.Truck.Add(truck);
                unitOfWork.Save();
                TempData["success"] = "Truck added successfully";
                return RedirectToAction(nameof(Index));

            }

            return View(truck);
        }


        // GET: TruckController/Delete/5
        public ActionResult Delete(int? id)
        {
            var truck = unitOfWork.Truck.GetFirstOrDefault(x => x.Id == id);
            if (id == 0 || id == null)
            {
                return NotFound();
            }

            if (truck == null)
            {
                return NotFound();
            }


            return View(truck);
        }

        // POST: TruckController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int? id)
        {
            var truck = unitOfWork.Truck.GetFirstOrDefault(x => x.Id == id);

            if (id == 0 || id == null)
            {
                return NotFound();
            }

            if (truck == null)
            {
                return NotFound();
            }

            unitOfWork.Truck.Remove(truck);
            unitOfWork.Save();
            TempData["success"] = "Truck deleted successfully";
            return RedirectToAction(nameof(Index));

        }

        #region API Calls
        [HttpGet]
        public IActionResult GetAll()
        {
            var truckList = unitOfWork.Truck.GetAll();
            return Json(new { data = truckList });
        }

        [HttpGet]
        // GET: DriverController/Edit/5
        public IActionResult Edit(int? id)
        {
            var truck = unitOfWork.Truck.GetFirstOrDefault(x => x.Id == id);
            if (id == null || id == 0)
            {
                return NotFound();
            }

            if (truck == null)
            {
                return NotFound();
            }

            return View(truck);
        }

        // POST: DriverController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Truck truck)
        {
            if (ModelState.IsValid == true)
            {
                unitOfWork.Truck.Update(truck);
                unitOfWork.Save();
                TempData["success"] = "Truck updated successfully";
                return RedirectToAction(nameof(Index));
            }

            return View(truck);
        }

        public IActionResult Details(int? id)
        {
            var truck = unitOfWork.Truck.GetFirstOrDefault(x => x.Id == id);

            if (id == 0 || id == null)
            {
                return NotFound();
            }

            if (truck == null)
            {
                return NotFound();
            }

            return View(truck);
        }


        #endregion
    }
}
