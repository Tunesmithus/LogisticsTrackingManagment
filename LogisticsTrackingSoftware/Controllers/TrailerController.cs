using LogisticsManagement.AppLogic.Contracts;
using LogisticsManagement.Common.StaticUtility;
using LogisticsManagement.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LogisticsManagement.Web.Controllers
{
    public class TrailerController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public TrailerController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        // GET: TrailerController

        public IActionResult Index()
        {
            return View();
        }

        // GET: TrailerController/Create
        public IActionResult Create()
        {
            var YearList = StaticList.GetYearList().Select(x => x.Text);
            ViewBag.YearList = YearList;

            var ColorList = StaticList.GetColors().Select(x => x.Text);
            ViewBag.ColorList = ColorList;

            var TrailerMakeList = StaticList.GetTrailerMakes().Select(x => x.Text);
            ViewBag.TrailerMakeList = TrailerMakeList;
            return View();
        }

        // POST: TrailerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Trailer trailer)
        {
            if (ModelState.IsValid)
            {
                unitOfWork.Trailer.Add(trailer);
                unitOfWork.Save();
                TempData["success"] = "Truck added successfully";
                return RedirectToAction(nameof(Index));
            }

            return View(trailer);

        }

        

        #region API Calls
        [HttpGet]
        public IActionResult GetAll()
        {
            var trailerList = unitOfWork.Trailer.GetAll();
            return Json(new { data = trailerList });
        }

        [HttpGet]
        // GET: DriverController/Edit/5
        public IActionResult Edit(int? id)
        {
            var trailer = unitOfWork.Trailer.GetFirstOrDefault(x => x.Id == id);
            if (id == null || id == 0)
            {
                return NotFound();
            }

            if (trailer == null)
            {
                return NotFound();
            }

            return View(trailer);
        }

        // POST: DriverController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Trailer trailer)
        {
            if (ModelState.IsValid == true)
            {
                unitOfWork.Trailer.Update(trailer);
                unitOfWork.Save();
                TempData["success"] = "Trailer updated successfully";
                return RedirectToAction(nameof(Index));
            }

            return View(trailer);
        }

        public IActionResult Details(int? id)
        {
            var trailer = unitOfWork.Trailer.GetFirstOrDefault(x => x.Id == id);

            if (id == 0 || id == null)
            {
                return NotFound();
            }

            if (trailer == null)
            {
                return NotFound();
            }

            return View(trailer);
        }

        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            var trailer = unitOfWork.Trailer.GetFirstOrDefault(x => x.Id == id);
            if (trailer == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

            unitOfWork.Trailer.Remove(trailer);
            unitOfWork.Save();
            return Json(new { success = true, message = "Delete successful" });
        }


        #endregion
    }
}

