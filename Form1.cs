using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Models.Person RegularEmployee = new Models.Person();

            RegularEmployee.FirstName = "Juan";
            RegularEmployee.LastName = "DelaCruz";


           string GetFullName = RegularEmployee.FullName();

            MessageBox.Show(GetFullName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Models.RegularEmployee emp = new RegularEmployee("Juan DelaCruz", 50000m);

            decimal salary = emp.CalculateSalary();

            string resultSalary = $"Monthly salary is {salary:N2}";

            MessageBox.Show(resultSalary);
        }
    }
}
