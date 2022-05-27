using LogisticsManagement.AppLogic.Contracts;
using LogisticsManagement.Common.StaticUtility;
using LogisticsManagement.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LogisticsManagement.Web.Controllers
{
    [Authorize(Roles = StaticDetail.Role_Administrator)]
    public class ExpenseTypeController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public ExpenseTypeController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }


        // GET: ExpenseTypeController
        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        // GET: ExpenseTypeController/Create
        public IActionResult Create()
        {
            return View();
        }

        [AllowAnonymous]
        // POST: ExpenseTypeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ExpenseType expenseType)
        {
            if (ModelState.IsValid == true)
            {
                if (User.IsInRole(StaticDetail.Role_Administrator))
                {
                    unitOfWork.ExpenseType.Add(expenseType);
                    unitOfWork.Save();
                    TempData["success"] = "Expense created successfully";
                    return RedirectToAction(nameof(Index));
                }

                if (User.IsInRole(StaticDetail.Role_User))
                {
                    unitOfWork.ExpenseType.Add(expenseType);
                    unitOfWork.Save();
                    TempData["success"] = "Expense created successfully";
                    return RedirectToAction(nameof(Create), "Expense");
                }
                
            }

            return View(expenseType);
        }

        #region API Calls

        public IActionResult GetAll()
        {
            var expenseTypeList = unitOfWork.ExpenseType.GetAll();
            return Json(new { data = expenseTypeList });
        }

        // GET: ExpenseTypeController/Edit/5
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var expenseType = unitOfWork.ExpenseType.GetFirstOrDefault(x => x.Id == id);
            if (expenseType == null)
            {
                return NotFound();
            }
            if (id == 0 || id == null)
            {
                return NotFound();
            }

            return View(expenseType);
        }

        // POST: ExpenseTypeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ExpenseType expenseType)
        {

            if (ModelState.IsValid == true)
            {
                unitOfWork.ExpenseType.Update(expenseType);
                unitOfWork.Save();
                TempData["success"] = "Expense type updated successfully";
                return RedirectToAction(nameof(Index));
            }

            return View(expenseType);

        }


        
        // POST: ExpenseTypeController/Delete/5
        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            var expenseType = unitOfWork.ExpenseType.GetFirstOrDefault(x => x.Id == id);
            if (id == null || id == 0)
            {
                return Json(new { success = false, message = "Error while deleting " });
            }

            if (expenseType == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

            unitOfWork.ExpenseType.Remove(expenseType);
            unitOfWork.Save();
            return Json(new { success = true, message = "Delete successful" });

        }
    }
    #endregion


}



