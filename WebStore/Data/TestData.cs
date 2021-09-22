using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Models;

namespace WebStore.Data
{
    public static class TestData
    {
        public static List<Employee> Employees { get; } = new()
        {
            new Employee { Id = 1, LastName = "Иванов", Name = "Иван", Patronymic = "Иванович", Age = 27, Info = "Первый сотрудник" },
            new Employee { Id = 2, LastName = "Петров", Name = "Пётр", Patronymic = "Петрович", Age = 31, Info = "Второй сотрудник" },
            new Employee { Id = 3, LastName = "Сидоров", Name = "Сидор", Patronymic = "Сидорович", Age = 18, Info = "Третий сотрудник" },
        };
    }

}
