using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HandsOnTest.BLL.EmployeeBLL;
using HandsOnTest.DTO.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HandsOnTest.Tests
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void GetEmployeeYearSalary()
        {
			decimal expectedYearSalary = 33120000;
			EmployeeSalary FakeEmployee = new EmployeeSalary(){
				Id = 1200,
				Name = "Julian",
				ContractTypeName = "HourlySalaryEmployee",
				RoleId = 1,
				RoleName = "Administrator",
				HourlySalary = 23000,
				MonthlySalary = 80000
			};

			Employee expectedEmployee = EmployeeFactory.GetFullEmployee(FakeEmployee);
			Assert.AreEqual(expectedEmployee.YearSalary, expectedYearSalary);
		}

    }
}
