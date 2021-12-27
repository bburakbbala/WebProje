using Clinic.DataAccess.Repository.IRepository;
using Clinic.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Clinic.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AddressController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public AddressController(IUnitOfWork unitOfWork)
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
            Address address = new Address();
            if (id == null)
            {
                // create
                return View(address);
            }

            // edit
            address = await _unitOfWork.Address.GetAsync(id.GetValueOrDefault());
            if (address == null)
            {
                return NotFound();
            }
            return View(address);
        }

        // in MVC we can do api calls within the controllers and view actions
        #region API_CALS

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var allObj = await _unitOfWork.Department.GetAllAsync();
            return Json(new { data = allObj });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Upsert(Department departmant)
        {
            if (ModelState.IsValid) // make sure validation is valid if client side is not working
            {
                if (departmant.Id == 0)
                {
                    await _unitOfWork.Department.AddAsync(departmant);
                }
                else
                {
                    _unitOfWork.Department.Update(departmant);
                }
                await _unitOfWork.SaveAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(departmant);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var objFromDb = await _unitOfWork.Department.GetAsync(id);
            if (objFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
            await _unitOfWork.Department.RemoveAsync(objFromDb);
            await _unitOfWork.SaveAsync();
            return Json(new { success = true, message = "Delete Successful" });
        }

        #endregion
    }
}
