using LogisticsManagement.AppLogic.Contracts;
using LogisticsManagement.AppLogic.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LogisticsManagement.Web.Controllers
{
    public class SettlementController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public SettlementController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        // GET: SettltementController
        public IActionResult Index()
        {
            var settlementList = unitOfWork.Settlement.GetAll();
            return View(settlementList);
        }

        // GET: SettltementController/Details/5
        public IActionResult Details(int id)
        {
            return View();
        }

        // GET: SettltementController/Create
        public IActionResult Create()
        {
            var DriverList = unitOfWork.Driver.GetAll().Select(x => new SelectListItem
            (text: x.FullName, value: x.Id.ToString()));

            ViewBag.DriverList = DriverList;

            var TruckList = unitOfWork.Truck.GetAll().Select(x => new SelectListItem
            (text: x.FullVehicleDescription.ToString(), value: x.Id.ToString()));

            ViewBag.TruckList = TruckList;

  
            return View();
        }

        // POST: SettltementController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(IFormCollection collection)
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

        // GET: SettltementController/Edit/5
        public IActionResult Edit(int id)
        {
            return View();
        }

        // POST: SettltementController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, IFormCollection collection)
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

        // GET: SettltementController/Delete/5
        public IActionResult Delete(int id)
        {
            return View();
        }

        // POST: SettltementController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, IFormCollection collection)
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
