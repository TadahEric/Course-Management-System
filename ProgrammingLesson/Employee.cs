using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingLesson
{
    class Employee
    {       
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double Salary { get; set; }
        public double Bonus { get; set; }

        public virtual void BonusCalculation()
        {
            Console.WriteLine("The fulltime Employee is entitled to 50% of annual salary");
        }
    }
}
