using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Domain.Models;

namespace WebStore.Interfaces.Services
{
    public interface IEmployeeData
    {
        IEnumerable<Employee> GetAll();

        Employee GetById(int id);

        int Add(Employee employee);

        void Update(Employee employee);

        bool Delete(int id);
    }

}
