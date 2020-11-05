using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnTest.DTO.Entities
{
    public class HourlyContractEmployee: Employee
    {
        public decimal HourlySalary { get; set; }
        public override decimal YearSalary => HourlySalary * 120 * 12;
    }
}
