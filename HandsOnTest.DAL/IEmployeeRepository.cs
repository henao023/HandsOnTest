using HandsOnTest.DTO.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HandsOnTest.DAL
{
    public interface IEmployeeRepository
    {
        /// <summary>
        /// Get a list of employees from Web Api as Data Repository
        /// </summary>
        Task<List<EmployeeSalary>> GetEmployees();

        /// <summary>
        /// Get a employee by Id from Web Api as Data Repository
        /// </summary>
        /// <param name="id"></param>
        Task<EmployeeSalary> GetEmployeeById(int id);
    }
}
