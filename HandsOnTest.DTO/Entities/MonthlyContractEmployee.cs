using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnTest.DTO.Entities
{
    public class MonthlyContractEmployee: Employee
    {
        public decimal MonthlySalary { get; set; }
        public override decimal YearSalary => MonthlySalary * 12;
    }
}
