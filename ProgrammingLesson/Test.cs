using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingLesson
{
    static class Test
    {
        //Solution to Task 30
        //Task 30
        //Add a new class to the project and call it 'Test' but make it a static class. 
        //Then call the newly created class from a Program class to see how it is different to call a 
        //Static class compare to an Instance class.

        //Below are members of Test class

        //Variables
        public static string firstName = "Dayo";
        public static string lastName = "Ayinde";

        //Properties
        public static string Age { get; set; }

        //Method or Function
        public static void FullName()
        {
            Console.WriteLine("His fullname is " + firstName + " " + lastName);
        }                

    }
}
