using LogisticsManagement.AppLogic.Contracts;
using LogisticsManagement.Common.StaticUtility;
using LogisticsManagement.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LogisticsManagement.Web.Controllers
{
    public class BrokerController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public BrokerController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        // GET: BrokerController
        public IActionResult Index()
        {
            return View();
        }


        // GET: BrokerController/Create
        public ActionResult Create()
        {
            var StateList = StaticList.GetStates().Select(x => x.Text);
            ViewBag.StateList = StateList;
            return View();
        }

        // POST: BrokerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Broker broker)
        {
            if (ModelState.IsValid)
            {
                unitOfWork.Broker.Add(broker);
                unitOfWork.Save();
                TempData["success"] = "Broker created successfully";
                return RedirectToAction(nameof(Index));
            }

            return View(broker);
        }

        


        #region API Calls
        [HttpGet]
        public IActionResult GetAll()
        {
            var brokerList = unitOfWork.Broker.GetAll();
            return Json(new { data = brokerList });
        }

        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            var broker = unitOfWork.Broker.GetFirstOrDefault(x => x.Id == id);
            if (broker == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

            unitOfWork.Broker.Remove(broker);
            unitOfWork.Save();
            return Json(new { success = true, message = "Delete successful" });
        }

        [HttpGet]
        // GET: BrokerController/Edit/5
        public IActionResult Edit(int? id)
        {
            var broker = unitOfWork.Broker.GetFirstOrDefault(x => x.Id == id);
            if (id == null || id == 0)
            {
                return NotFound();
            }

            if (broker == null)
            {
                return NotFound();
            }

            return View(broker);
        }

        // POST: BrokerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Broker broker)
        {
            if (ModelState.IsValid == true)
            {
                unitOfWork.Broker.Update(broker);
                unitOfWork.Save();
                TempData["success"] = "Truck updated successfully";
                return RedirectToAction(nameof(Index));
            }

            return View(broker);
        }

        public IActionResult Details(int? id)
        {
            var broker = unitOfWork.Broker.GetFirstOrDefault(x => x.Id == id);

            if (id == 0 || id == null)
            {
                return NotFound();
            }

            if (broker == null)
            {
                return NotFound();
            }

            return View(broker);
        }


        #endregion
    }
}
