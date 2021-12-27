using Clinic.DataAccess.Repository.IRepository;
using Clinic.Models;
using Clinic.Models.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Clinic.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HospitalController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _hostEnvironment; // for image uploading

        public HospitalController(IUnitOfWork unitOfWork, IWebHostEnvironment hostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _hostEnvironment = hostEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Upsert(Guid? id)
        {
            IEnumerable<Department> departments = await _unitOfWork.Department.GetAllAsync();
            IEnumerable<Lab> labs = await _unitOfWork.Lab.GetAllAsync();
            HospitalVM hospitalVM = new HospitalVM()
            {
                Hospital = new Hospital(),
                DepartmentList = departments.Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                }),
                LabList = departments.Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                })
            };
            if (id == null)
            {
                // create
                return View(hospitalVM);
            }
            // edit
            hospitalVM.Hospital = await _unitOfWork.Hospital.GetAsync(id.GetValueOrDefault());
            if (hospitalVM.Hospital == null)
            {
                return NotFound();
            }
            return View();
        }

        #region API_CALS

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var allObj = await _unitOfWork.Hospital.GetAllAsync();
            return Json(new { data = allObj });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Upsert(HospitalVM hospitalVm)
        {
            if (ModelState.IsValid)
            {
                string webRootPath = _hostEnvironment.WebRootPath;
                var files = HttpContext.Request.Form.Files;
                if (files.Count > 0)
                {
                    string fileName = Guid.NewGuid().ToString();
                    var uploads = Path.Combine(webRootPath, @"images\hospitals\");
                    var extension = Path.GetExtension(files[0].FileName);

                    if (hospitalVm.Hospital.ImageUrl != null)
                    {
                        // edit remove old image
                        var imagePath = Path.Combine(webRootPath, hospitalVm.Hospital.ImageUrl.TrimStart('\\'));
                        if (System.IO.File.Exists(imagePath))
                        {
                            System.IO.File.Delete(imagePath);
                        }
                    }
                    using (var filesStreams = new FileStream(Path.Combine(uploads, fileName + extension), FileMode.Create))
                    {
                        files[0].CopyTo(filesStreams);
                    }
                    hospitalVm.Hospital.ImageUrl = @"\images\hospitals\" + fileName + extension;
                }
                else
                {
                    // update do not change image
                    if (!hospitalVm.Hospital.Id.Equals(""))
                    {
                        Hospital objFromDb = await _unitOfWork.Hospital.GetAsync(hospitalVm.Hospital.Id);
                        hospitalVm.Hospital.ImageUrl = objFromDb.ImageUrl;
                    }
                }
                if (hospitalVm.Hospital.Id.Equals(""))
                {
                    await _unitOfWork.Hospital.AddAsync(hospitalVm.Hospital);
                }
                else
                {
                    _unitOfWork.Hospital.Update(hospitalVm.Hospital);
                }
                await _unitOfWork.SaveAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hospitalVm);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(Guid id)
        {
            var objFromDb = await _unitOfWork.Hospital.GetAsync(id);
            if (objFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
            // remove image
            string webRootPath = _hostEnvironment.WebRootPath;
            var imagePath = Path.Combine(webRootPath, objFromDb.ImageUrl.TrimStart('\\'));
            if (System.IO.File.Exists(imagePath))
            {
                System.IO.File.Delete(imagePath);
            }
            await _unitOfWork.Hospital.RemoveAsync(objFromDb);
            await _unitOfWork.SaveAsync();
            return Json(new { success = true, message = "Delete Successful" });
        }

        #endregion
    }
}
