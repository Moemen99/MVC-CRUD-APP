using AutoMapper;
using Demo.BLL.Interfaces;
using Demo.BLL.Repositories;
using Demo.DAL.Models;
using Demo.PL.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Demo.PL.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DepartmentController(IUnitOfWork unitOfWork , IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var departments = _unitOfWork.Department.GetAll();
            var mappedDepts = _mapper.Map<IEnumerable<Department>, IEnumerable<DepartmentViewModel>>(departments);

            return View(mappedDepts);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(DepartmentViewModel departmentVM)
        {
            if (ModelState.IsValid)
            {
                var mappedDept = _mapper.Map<DepartmentViewModel,Department>(departmentVM);
                _unitOfWork.Department.Add(mappedDept);
                var count = _unitOfWork.Complete();
                if(count > 0)
                    return RedirectToAction(nameof(Index));
            }
            return View(departmentVM);
        }

        [HttpGet]

        public IActionResult Details (int? id, string ViewName= "Details")
        {
            if (id is null)
                return BadRequest();
            var department = _unitOfWork.Department.GetById(id.Value);
            var mappedDepts = _mapper.Map<Department, DepartmentViewModel>(department);

            if (mappedDepts is null)
                return NotFound();
            return View(ViewName, mappedDepts);
        }
        [HttpGet]
        public IActionResult Update(int? id)
        {
           return Details(id, "Update");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update([FromRoute] int id,DepartmentViewModel dept)
        {
            if(id != dept.Id)
                return BadRequest();
            if (ModelState.IsValid)
            {
                try
                {
                    var mappedDept = _mapper.Map<DepartmentViewModel, Department>(dept);
                    _unitOfWork.Department.Update(mappedDept);
                    _unitOfWork.Complete();
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, ex.Message);
                }
            }
            return View(dept);
        }
        public IActionResult Delete(int? id)
        {
            return Details(id,"Delete");
        }
        [HttpPost]
        public IActionResult Delete([FromRoute] int id,DepartmentViewModel dept)
        {
            if (id != dept.Id)
                return BadRequest();
            try
            {
                var mappedDept= _mapper.Map<DepartmentViewModel, Department>(dept);
            _unitOfWork.Department.Delete(mappedDept);
                _unitOfWork.Complete();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
                return View(dept);
            }
        }




    }
}
