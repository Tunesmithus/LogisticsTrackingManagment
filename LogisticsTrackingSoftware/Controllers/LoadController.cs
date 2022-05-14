using LogisticsManagement.AppLogic.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LogisticsManagement.Web.Controllers
{
    public class LoadController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public LoadController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        // GET: LoadController
        public ActionResult Index()
        {
            return View();
        }

        // GET: LoadController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LoadController/Create
        public ActionResult Create()
        {
            var DriverList = unitOfWork.Driver.GetAll().Select(x => new SelectListItem
            (text: x.FirstName, value: x.Id.ToString()));

            ViewBag.DriverList = DriverList;

            var TruckList = unitOfWork.Truck.GetAll().Select(x => new SelectListItem
            (text: x.EquipmentNumber.ToString(), value: x.Id.ToString()));

            ViewBag.TruckList = TruckList;

            var TrailerList = unitOfWork.Trailer.GetAll().Select(x => new SelectListItem
            (text: x.EquipmentNumber.ToString(), value: x.Id.ToString()));

            ViewBag.TrailerList = TrailerList;

            var BrokerList = unitOfWork.Broker.GetAll().Select(x => new SelectListItem
            (text: x.CompanyName, value: x.Id.ToString()));

            ViewBag.BrokerList = BrokerList;

            var DispatcherList = unitOfWork.Dispatcher.GetAll().Select(x => new SelectListItem
            (text: x.Name, value: x.Id.ToString()));

            ViewBag.DispatcherList = DispatcherList; 

            return View();
        }

        // POST: LoadController/Create
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

        // GET: LoadController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LoadController/Edit/5
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

        // GET: LoadController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LoadController/Delete/5
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

        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            var loadList = unitOfWork.Load.GetAll();
            return Json( new { data = loadList });
        }


        #endregion
    }
}
