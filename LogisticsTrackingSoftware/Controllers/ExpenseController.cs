using LogisticsManagement.AppLogic.Contracts;
using LogisticsManagement.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LogisticsManagement.Web.Controllers
{
    public class ExpenseController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public ExpenseController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        // GET: ExpenseController
        public IActionResult Index()
        {
            var expenseList = unitOfWork.Expense.GetAll(includeProperties: "Driver,Truck,Trailer,Load,ExpenseType");
            return View(expenseList);
        }

        // GET: ExpenseController/Details/5
        public IActionResult Details(int id)
        {
            return View();
        }

        // GET: ExpenseController/Create
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

        // POST: ExpenseController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Expense expense)
        {
            try
            {
                if (ModelState.IsValid == true)
                {
                    unitOfWork.Expense.Add(expense);
                    unitOfWork.Save();
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(expense);
            }
        }

        // GET: ExpenseController/Edit/5
        public IActionResult Edit(int? id)
        {
            var expense = unitOfWork.Expense.GetFirstOrDefault(x => x.Id == id);
            if (expense == null)
            {
                return NotFound();
            }
            if (id == null || id == 0)
            {
                return NotFound();
            }

            return View(expense);
        }

        // POST: ExpenseController/Edit/5
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

        // GET: ExpenseController/Delete/5
        public IActionResult Delete(int id)
        {
            return View();
        }

        // POST: ExpenseController/Delete/5
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
