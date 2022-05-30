using LogisticsManagement.AppLogic.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LogisticsManagement.Web.Controllers
{
    public class DeductionController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public DeductionController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        // GET: ReimbursementController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ReimbursementController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ReimbursementController/Create
        public ActionResult Create()
        {
            var ExpenseTypeList = unitOfWork.ExpenseType.GetAll().Select(x => new SelectListItem(text: x.ExpenseCategory,
                value: x.Id.ToString()));

            ViewBag.ExpenseTypeList = ExpenseTypeList;

            var DriverList = unitOfWork.Driver.GetAll().Select(x => new SelectListItem
            (text: x.FullName, value: x.Id.ToString()));

            ViewBag.DriverList = DriverList;

            var TruckList = unitOfWork.Truck.GetAll().Select(x => new SelectListItem
            (text: x.FullVehicleDescription, value: x.Id.ToString()));

            ViewBag.TruckList = TruckList;

            var TrailerList = unitOfWork.Trailer.GetAll().Select(x => new SelectListItem
            (text: x.FullTrailerDescription.ToString(), value: x.Id.ToString()));

            ViewBag.TrailerList = TrailerList;

            var LoadList = unitOfWork.Load.GetAll().Select(x => new SelectListItem(text: x.FullLoadDescription, value: x.Id.ToString()));
            ViewBag.LoadList = LoadList;

            return View();
        }

        // POST: ReimbursementController/Create
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

        // GET: ReimbursementController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ReimbursementController/Edit/5
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

        // GET: ReimbursementController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ReimbursementController/Delete/5
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
