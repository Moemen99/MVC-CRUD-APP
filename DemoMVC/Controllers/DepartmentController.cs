using AutoMapper;
using Demo.BLL.Interfaces;
using Demo.DAL.Models;
using Demo.PL.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Demo.PL.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentRepository _departmentRepository;
        private readonly IMapper _mapper;

        public DepartmentController(IDepartmentRepository departmentRepository , IMapper mapper)
        {
            _departmentRepository = departmentRepository;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var departments = _departmentRepository.GetAll();
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
            var count = _departmentRepository.Add(mappedDept);
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
            var department = _departmentRepository.GetById(id.Value);
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
                    _departmentRepository.Update(mappedDept);
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
            _departmentRepository.Delete(mappedDept);
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
