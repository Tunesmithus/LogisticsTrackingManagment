using LogisticsManagement.AppLogic.Contracts;
using LogisticsManagement.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LogisticsManagement.Web.Controllers
{
    public class DispatcherController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public DispatcherController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        // GET: DispatcherController
        public IActionResult Index()
        {
            return View();
        }


        // GET: DispatcherController/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DispatcherController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Dispatcher dispatcher)
        {
            if (ModelState.IsValid == true)
            {
                unitOfWork.Dispatcher.Add(dispatcher);
                unitOfWork.Save();
                TempData["success"] = "Dispatcher created successfully";
                return RedirectToAction(nameof(Index));
            }

            return View(dispatcher);
        }

        #region API Calls

        public IActionResult GetAll()
        {
            var dispatcherList = unitOfWork.Dispatcher.GetAll();
            return Json(new { data = dispatcherList });
        }

        // GET: DispatcherController/Edit/5
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var dispatcher = unitOfWork.Dispatcher.GetFirstOrDefault(x => x.Id == id);
            if (dispatcher == null)
            {
                return NotFound();
            }
            if (id == 0 || id == null)
            {
                return NotFound();
            }

            return View(dispatcher);
        }

        // POST: DispatcherController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Dispatcher dispatcher)
        {

            if (ModelState.IsValid == true)
            {
                unitOfWork.Dispatcher.Update(dispatcher);
                unitOfWork.Save();
                TempData["success"] = "Dispatcher updated successfully";
                return RedirectToAction(nameof(Index));
            }

            return View(dispatcher);

        }

        

        // POST: DispatcherController/Delete/5
        [HttpDelete]
        public IActionResult Delete(int? id)
        {
           var dispatcher = unitOfWork.Dispatcher.GetFirstOrDefault(x => x.Id == id);
            if (id == null || id == 0)
            {
                return NotFound();
            }

            if (dispatcher == null)
            {
                return NotFound();
            }

            unitOfWork.Dispatcher.Remove(dispatcher);
            unitOfWork.Save();
            return Json(new { success = true, message = "Delete successful" });
            
        }
    }
    #endregion
}
