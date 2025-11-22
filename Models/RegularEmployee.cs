using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;





namespace WindowsFormsApp1.Models
{
    public class RegularEmployee : Employee
    {

        public RegularEmployee(string name, decimal monthlySalary)
        {
            this.Name = name;
            this.MonthlySalary = monthlySalary;

        }

        public override decimal CalculateSalary()
        {
            return this.MonthlySalary;
        }


    }
}
