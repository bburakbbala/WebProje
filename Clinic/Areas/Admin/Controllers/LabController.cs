using Clinic.DataAccess.Repository.IRepository;
using Clinic.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Clinic.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LabController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public LabController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }

        // update and insert; id == null ? insert : update
        public async Task<IActionResult> Upsert(int? id)
        {
            Lab lab = new Lab();
            if (id == null)
            {
                // create
                return View(lab);
            }

            // edit
            lab = await _unitOfWork.Lab.GetAsync(id.GetValueOrDefault());
            if (lab == null)
            {
                return NotFound();
            }
            return View(lab);
        }

        #region API_CALS

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var allObj = await _unitOfWork.Lab.GetAllAsync();
            return Json(new { data = allObj });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Upsert(Lab lab)
        {
            if (ModelState.IsValid) // make sure validation is valid if client side is not working
            {
                if (lab.Id.Equals(""))
                {
                    await _unitOfWork.Lab.AddAsync(lab);
                }
                else
                {
                    _unitOfWork.Lab.Update(lab);
                }
                await _unitOfWork.SaveAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lab);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(Guid id)
        {
            var objFromDb = await _unitOfWork.Lab.GetAsync(id);
            if (objFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
            await _unitOfWork.Lab.RemoveAsync(objFromDb);
            await _unitOfWork.SaveAsync();
            return Json(new { success = true, message = "Delete Successful" });
        }

        #endregion
    }
}
