using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingLesson
{
    class PartTimeEmployee : Employee
    {
        public override void BonusCalculation()
        {
            Console.WriteLine("The parttime Employee is entitled to 20% of annual salary");
        }
    }
}
