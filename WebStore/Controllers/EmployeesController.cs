using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebStore.Data;
using WebStore.Models;
using WebStore.Services.Interfaces;

namespace WebStore.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IEmployeeData _EmployeeData;
        private readonly ILogger<EmployeesController> _Logger;

        public EmployeesController(IEmployeeData EmployeeData, ILogger<EmployeesController> Logger)
        {
            _EmployeeData = EmployeeData;
            _Logger = Logger;
        }
        public IActionResult Index()
        {
            return View(_EmployeeData.GetAll());
        }

        public IActionResult Details(int id)
        {
            var employee = _EmployeeData.GetById(id);
            if (employee is null)
                return NotFound();

            return View(employee);
        }
    }
}
