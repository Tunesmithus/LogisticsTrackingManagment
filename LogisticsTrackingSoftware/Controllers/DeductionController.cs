using LogisticsManagement.AppLogic.Contracts;
using LogisticsManagement.Data;
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
        public IActionResult Index()
        {
            var dedutionList = unitOfWork.Deduction.GetAll(includeProperties:"Driver,Truck,Trailer,Load,ExpenseType");
            return View(dedutionList);
        }

        // GET: ReimbursementController/Details/5
        public IActionResult Details(int id)
        {
            return View();
        }

        // GET: ReimbursementController/Create
        public IActionResult Create()
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

        // POST: DeductionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Deduction deduction)
        {
            try
            {
                if(ModelState.IsValid == true)
                {
                    unitOfWork.Deduction.Add(deduction);
                    unitOfWork.Save();
                    return RedirectToAction(nameof(Index));
                }
                
            }
            catch
            {
                return View(deduction);
            }

            return View(deduction);
        }

        // GET: DeductionController/Edit/5
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var deductionEdit = unitOfWork.Deduction.GetFirstOrDefault(x => x.Id == id);

            if (deductionEdit == null)
            {
                return NotFound();
            }
            if (id == 0)
            {
                return NotFound();
            }
            return View(deductionEdit);
        }

        // POST: DeductionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Deduction deduction)
        {
            try
            {
                if (ModelState.IsValid == true)
                {
                    unitOfWork.Deduction.Update(deduction);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(deduction);
            }
        }

        // GET: DeductionController/Delete/5
        public IActionResult Delete(int id)
        {
            return View();
        }

        // POST: ReimbursementController/Delete/5
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
