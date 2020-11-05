using HandsOnTest.BLL.EmployeeBLL;
using HandsOnTest.DTO.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace HandsOnTest.Controllers
{
    //[Route("api/[controller]")]
    public class EmployeeApiController : ApiController
    {
        #region Properties

        private readonly IEmployeeBLL _employeeBll;

        #endregion

        #region Public Methods

        public EmployeeApiController(IEmployeeBLL employeeBll)
        {
            _employeeBll = employeeBll;
        }

        /// <summary>
        /// It mean GET api/Employee
        /// </summary>
        /// <returns></returns>
        //[HttpGet]
        //[Route("EmployeeApi")]
        [Route("api/EmployeeApi")]
        public async Task<List<Employee>> Get()
        {
            return await _employeeBll.GetEmployees();
        }


        /// <summary>
        /// It mean GET api/Employee/number
        /// </summary>
        /// <param name="idEmployee"></param>
        /// <returns></returns>
        //[HttpGet]
        [Route("api/EmployeeApi/{idEmployee}")]
        public async Task<List<Employee>> Get(int idEmployee)
        {
            List<Employee> lstEmployees = new List<Employee>();
            Employee employee = await _employeeBll.GetEmployeeById(idEmployee);
            if (employee != null)
            {
                lstEmployees.Add(employee);
            }
            return lstEmployees;
        }

        #endregion

        #region Private Methods

        #endregion

    }

}
