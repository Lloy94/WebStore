using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        private static readonly List<Employee> __Employees = new()
        {
            new Employee { Id = 1, LastName = "Иванов", Name = "Иван", Patronymic = "Иванович", Age = 27, Info = "Первый сотрудник" },
            new Employee { Id = 2, LastName = "Петров", Name = "Пётр", Patronymic = "Петрович", Age = 31, Info = "Второй сотрудник" },
            new Employee { Id = 3, LastName = "Сидоров", Name = "Сидор", Patronymic = "Сидорович", Age = 18, Info = "Третий сотрудник" },
        };
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Employees()
        {
            return View(__Employees);
        }
    }
}
