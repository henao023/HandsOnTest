using HandsOnTest.DTO.Entities;

namespace HandsOnTest.BLL.EmployeeBLL
{
	public class EmployeeFactory
	{
		#region Properties

		#endregion

		#region Public Methods

		public static Employee GetFullEmployee(EmployeeSalary pEmployee)
		{
			Employee employee = null;

			switch (pEmployee.ContractTypeName)
			{
				case "HourlySalaryEmployee":
					employee = new HourlyContractEmployee()
					{
						HourlySalary = pEmployee.HourlySalary
					};

					break;
				case "MonthlySalaryEmployee":
					employee = new MonthlyContractEmployee()
					{
						MonthlySalary = pEmployee.MonthlySalary
					};
					break;
			}

			employee.Id = pEmployee.Id;
			employee.ContractTypeName = pEmployee.ContractTypeName;
			employee.Name = pEmployee.Name;
			employee.RoleDescription = pEmployee.RoleDescription ?? string.Empty;
			employee.RoleName = pEmployee.RoleName;
			employee.RoleId = pEmployee.RoleId;

			return employee;
		}

		#endregion

		#region Private Methods

		#endregion
	}
}
