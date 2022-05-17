using LogisticsManagement.AppLogic.Contracts;
using LogisticsManagement.Data;
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
        public IActionResult Index()
        {
            return View();
        }


        // GET: LoadController/Create
        public IActionResult Create()
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
        public IActionResult Create(Load load)
        {
            if (!ModelState.IsValid == true)
            {
                unitOfWork.Load.Add(load);
                unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }

            return View(load);
            
        }

        // GET: LoadController/Details/5
        [HttpGet]
        public IActionResult Details(int? id)
        {
            var loadDetails = unitOfWork.Load.GetFirstOrDefault(x => x.Id == id, includeProperties: "Driver,Trailer,Broker,Truck,Dispatcher");
            if (id == 0 || id == null)
            {
                return NotFound();
            }

            if (loadDetails == null)
            {
                return NotFound();
            }

            return View(loadDetails);
        }


        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            var loadList = unitOfWork.Load.GetAll();
            return Json( new { data = loadList });
        }

        // GET: LoadController/Edit/5
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var load = unitOfWork.Load.GetFirstOrDefault(x => x.Id == id);

            if (id == null || id == 0)
            {
                return NotFound();
            }

            if (load == null)
            {
                return NotFound();
            }

            return View(load);
        }

        // POST: LoadController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Load load)
        {
            if (ModelState.IsValid == true)
            {
                unitOfWork.Load.update(load);
                unitOfWork.Save();
                TempData["success"] = "Load updated successfully";
                return RedirectToAction(nameof(Index));
            }

            return View(load);
        }

        //// GET: LoadController/Details/5
        //[HttpGet]
        //public IActionResult Details(int? id)
        //{
        //    var loadDetails = unitOfWork.Load.GetFirstOrDefault(x => x.Id == id);
        //    if (id == 0 || id == null)
        //    {
        //        return NotFound();
        //    }

        //    if (loadDetails == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(loadDetails);
        //}

        // POST: LoadController/Delete/5
        [HttpDelete]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int? id)
        {
            var load = unitOfWork.Load.GetFirstOrDefault(x => x.Id == id);

            if (id == 0 || id == null)
            {
                return NotFound();
            }

            if (load == null)
            {
                return NotFound();
            }

            unitOfWork.Load.Remove(load);
            unitOfWork.Save();
            TempData["success"] = "Load removed successfully";
            return RedirectToAction(nameof(Index));
        }



        #endregion
    }
}
