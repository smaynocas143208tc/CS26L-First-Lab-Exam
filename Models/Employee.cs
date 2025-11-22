using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public  abstract class Employee
    {

        public string Name { get; set; }
        public decimal MonthlySalary { get; set; }

        public abstract decimal CalculateSalary();

    }
}
