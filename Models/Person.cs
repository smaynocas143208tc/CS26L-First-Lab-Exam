using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
   public class Person
    {
        protected int IdNumber;
        public string FirstName;
        public string LastName;
        public DateTime DateOfBirth;
        public string Gender;
        public string Address;


        public string FullName()
        {

            string fullname = ("Hello "+LastName+"," + " " + FirstName);
            return fullname;


        }

      
    }
}
