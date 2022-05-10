using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;
using BulkyBook.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BulkyBookWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class CoverTypeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public CoverTypeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            IEnumerable<CoverType> objCoverTypeList = _unitOfWork.CoverType.GetAll();
            return View(objCoverTypeList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CoverType type)
        {
            if(ModelState.IsValid)
            {
                _unitOfWork.CoverType.Add(type);
                _unitOfWork.Save();
                TempData["success"] = "Cover Type Created Successfully";
                return RedirectToAction("Index");
            }
            return View(type);
        }

        //GET
        public IActionResult Edit(int id)
        {
            var type = _unitOfWork.CoverType.GetFirstOrDefault(u => u.Id == id);
            return View(type);
        }

        [HttpPost]
        public IActionResult Edit(CoverType type)
        {
            if(ModelState.IsValid)
            {
                _unitOfWork.CoverType.Update(type);
                _unitOfWork.Save();
                TempData["success"] = "Cover Type Updated Successfully";
                return RedirectToAction("Index");
            }
            return View(type);
        }

        //GET
        public IActionResult Delete(int? id)
        {
            var type = _unitOfWork.CoverType.GetFirstOrDefault(u => u.Id == id);
            return View(type);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            var type = _unitOfWork.CoverType.GetFirstOrDefault(u => u.Id == id);

            if (id==null)
            {
                return NotFound();
            }
            _unitOfWork.CoverType.Remove(type);
            _unitOfWork.Save();
            TempData["success"] = "Cover Type Deleted Successfully";
            return RedirectToAction("Index");
        }
    }
}