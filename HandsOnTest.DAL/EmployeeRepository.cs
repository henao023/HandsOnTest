using HandsOnTest.DTO.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace HandsOnTest.DAL
{
    public class EmployeeRepository : IEmployeeRepository
    {

        #region Properties

        #endregion

        #region Public Methods

        public async Task<List<EmployeeSalary>> GetEmployees()
        {
            return await GetEmployeesFromApiRepository();
        }

        public async Task<EmployeeSalary> GetEmployeeById(int idEmployee)
        {
            var employees = await GetEmployeesFromApiRepository();
            return employees.Find(x => x.Id == idEmployee);
        }

        #endregion

        #region Private Methods

    
		private async Task<List<EmployeeSalary>> GetEmployeesFromApiRepository()
		{
			List<EmployeeSalary> employees = new List<EmployeeSalary>();

			var hostEmployee = ConfigurationManager.AppSettings["HostEmployeesService"];
			
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = await client.GetAsync(hostEmployee);
                if (response.IsSuccessStatusCode)
                {
                    var EmployeeResponse = await response.Content.ReadAsStringAsync();
                    employees = JsonConvert.DeserializeObject<List<EmployeeSalary>>(EmployeeResponse);
                }
            }
            return employees;
		}
        #endregion
    }

}
