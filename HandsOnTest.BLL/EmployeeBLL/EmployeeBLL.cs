using HandsOnTest.DAL;
using HandsOnTest.DTO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnTest.BLL.EmployeeBLL
{
    public class EmployeeBLL: IEmployeeBLL
    {
        #region Properties

        private readonly IEmployeeRepository _employeeRepository;

        #endregion

        #region Public Methods

        public EmployeeBLL(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<List<Employee>> GetEmployees()
		{
			try
			{
				List<EmployeeSalary> employees = await _employeeRepository.GetEmployees();
				List<Employee> lstEmployee = new List<Employee>();
				foreach (var emp in employees)
				{
					Employee employee = EmployeeFactory.GetFullEmployee(emp);
					lstEmployee.Add(employee);
				}
				return lstEmployee;
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}

		public async Task<Employee> GetEmployeeById(int idEmployee)
		{
			try
			{
				EmployeeSalary emp = await _employeeRepository.GetEmployeeById(idEmployee);
				return emp != null ? EmployeeFactory.GetFullEmployee(emp) : null;

			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}

        #endregion

        #region Private Methods

        #endregion 
    }
}
