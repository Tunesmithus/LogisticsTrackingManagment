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
        public ActionResult Create()
        {
            var TrailerMakeList = StaticList.GetTrailerMakes().Select(x => x.Text);
            ViewBag.TrailerMakeList = TrailerMakeList;
            return View();
        }

        // POST: TrailerController/Create
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

        // GET: TrailerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TrailerController/Edit/5
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

        // GET: TrailerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TrailerController/Delete/5
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


        #endregion
    }
}

