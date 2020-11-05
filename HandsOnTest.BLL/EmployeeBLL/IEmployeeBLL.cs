using HandsOnTest.DTO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnTest.BLL.EmployeeBLL
{
    public interface IEmployeeBLL
    {
        Task<List<Employee>> GetEmployees();
        Task<Employee> GetEmployeeById(int id);
    }
}
