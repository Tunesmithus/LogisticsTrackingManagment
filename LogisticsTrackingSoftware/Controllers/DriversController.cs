using LogisticsManagement.AppLogic.Contracts;
using LogisticsManagement.Common.StaticUtility;
using LogisticsManagement.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LogisticsManagement.Web.Controllers
{
    public class DriversController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public DriversController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        // GET: DriverController
        public IActionResult Index()
        {

            return View();
        }

        
        public IActionResult Create()
        {
            var StateList = StaticList.GetStates().Select(x => x.Text);
            ViewBag.StateList = StateList;
            return View();
        }

        // POST: DriverController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Driver driver)
        {
            if (ModelState.IsValid == true)
            {
                unitOfWork.Driver.Add(driver);
                unitOfWork.Save();
                TempData["success"] = "Driver created successfully";
                return RedirectToAction(nameof(Index));
            }

            return View(driver);
        }

       

        // POST: DriverController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public IActionResult Edit(Driver driver)
        //{
        //    if (ModelState.IsValid == true)
        //    {
        //        unitOfWork.Driver.Update(driver);
        //        unitOfWork.Save();
        //        TempData["success"] = "Driver updated successfully";
        //        return RedirectToAction(nameof(Index));
        //    }

        //    return View(driver);
        //}

        // GET: DriverController/Delete/5
        public IActionResult Delete(int? id)
        {
            var driver = unitOfWork.Driver.GetFirstOrDefault(x => x.Id == id);

            if (id == 0 || id == null)
            {
                return NotFound();
            }

            if (driver == null)
            {
                return NotFound();
            }

            return View(driver);
        }

        // POST: DriverController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var driver = unitOfWork.Driver.GetFirstOrDefault(x=> x.Id == id);

            if (driver == null)
            {
                return NotFound();
            }

            unitOfWork.Driver.Remove(driver);
            unitOfWork.Save();
            TempData["success"] = "Driver deleted successfully";
            return RedirectToAction(nameof(Index));

        }



        #region API Calls
        [HttpGet]
        public IActionResult GetAll()
        {
            var driverList = unitOfWork.Driver.GetAll();
            return Json(new { data = driverList });
        }

        [HttpGet]
        // GET: DriverController/Edit/5
        public IActionResult Edit(int? id)
        {
            var driver = unitOfWork.Driver.GetFirstOrDefault(x => x.Id == id);
            if (id == null || id == 0)
            {
                return NotFound();
            }

            if (driver == null)
            {
                return NotFound();
            }

            return View(driver);
        }

        // POST: DriverController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Driver driver)
        {
            if (ModelState.IsValid == true)
            {
                unitOfWork.Driver.Update(driver);
                unitOfWork.Save();
                TempData["success"] = "Driver updated successfully";
                return RedirectToAction(nameof(Index));
            }

            return View(driver);
        }

        public IActionResult Details(int? id)
        {
            var driver = unitOfWork.Driver.GetFirstOrDefault(x => x.Id == id);

            if (id == 0 || id == null)
            {
                return NotFound();
            }

            if (driver == null)
            {
                return NotFound();
            }

            return View(driver);
        }


        #endregion
    }
}
