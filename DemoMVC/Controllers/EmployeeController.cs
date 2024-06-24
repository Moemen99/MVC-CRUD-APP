using AutoMapper;
using Demo.BLL.Interfaces;
using Demo.DAL.Models;
using Demo.PL.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo.PL.Controllers
{
    public class EmployeeController : Controller
    {
      
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public EmployeeController(IUnitOfWork unitOfWork, IMapper mapper )
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public IActionResult Index(string SearchInput)
        {
            var Employees = Enumerable.Empty<Employee>();
            if (string.IsNullOrEmpty(SearchInput))

                Employees = _unitOfWork.Employee.GetAll();
            else
                Employees = _unitOfWork.Employee.GetEmployeeByName(SearchInput.ToLower());
            var mappedEmployees = _mapper.Map<IEnumerable<Employee>, IEnumerable<EmployeeViewModel>>(Employees);
            return View(mappedEmployees);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(EmployeeViewModel employeeVM)
        {
            if (ModelState.IsValid)
            {
                var mappedEmp = _mapper.Map<EmployeeViewModel,Employee>(employeeVM);
                 _unitOfWork.Employee.Add(mappedEmp);
                var count = _unitOfWork.Complete();


                if (count > 0)
                    return RedirectToAction(nameof(Index));
            }
            return View(employeeVM);
        }

        [HttpGet]

        public IActionResult Details(int? id, string ViewName = "Details")
        {
            if (id is null)
                return BadRequest();
            var employee = _unitOfWork.Employee.GetById(id.Value);
            var mappedEmployees = _mapper.Map<Employee, EmployeeViewModel>(employee);

            if (mappedEmployees is null)
                return NotFound();
            return View(ViewName, mappedEmployees);
        }
        [HttpGet]
        public IActionResult Update(int? id)
        {
            return Details(id, "Update");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update([FromRoute] int id, EmployeeViewModel dept)
        {
            if (id != dept.Id)
                return BadRequest();
            if (ModelState.IsValid)
            {
                try
                {
                    var mappedDept = _mapper.Map<EmployeeViewModel,Employee>(dept);
                    _unitOfWork.Employee.Update(mappedDept);
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
            return Details(id, "Delete");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete([FromRoute] int id, EmployeeViewModel employeeVM)
        {
            if (id != employeeVM.Id)
                return BadRequest();
            try
            {
                var mappedEmp= _mapper.Map<EmployeeViewModel,Employee>(employeeVM);
                _unitOfWork.Employee.Delete(mappedEmp);
                _unitOfWork.Complete();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
                return View(employeeVM);
            }
        }


    }
}
