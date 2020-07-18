using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingLesson
{
    class ClassTwoToDisplayHNY
    {
        //Task 9
        //Write a computer program to display "Happy New Year" 9 times. Use 3 new methods that belong to 3 different classes 
        //apart from Program Class to solve the problem. And display the result to the console.
        public void MethodTwoFromClassTwoToDisplayHNY()
        {
            Console.WriteLine("4. Happy New Year");
            Console.WriteLine("5. Happy New Year");
            Console.WriteLine("6. Happy New Year");
        }

        //Task 12
        //Write a computer program to allow a method to take two parameters that can be used for addition within that 
        //method. Return the answer to a variable that will call it and multiply the answer by 3 to get a new value 
        //to be written to the console.
        public double AdditionOfTwoNumbers(double number1, double number2)
        {
            double addition = number1 + number2;
            Console.WriteLine($"Addition of {number1} and {number2} = {addition}");
            return addition;
        }       
        
    }
}
