using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnTest.DTO.Entities
{
    public class EmployeeSalary: Employee
    {
        public decimal HourlySalary { get; set; }
        public decimal MonthlySalary { get; set; }
    }
}
