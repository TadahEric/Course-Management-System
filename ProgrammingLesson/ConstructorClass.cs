using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingLesson
{
    class ConstructorClass
    {
        //A constructor is like a method with the same name as the class. It has no return keyword
        //Constructor will be the method that get executed first when an instance of a class (an object) is created.
        //It can be used to set default values

        //Write a computer program to create a class with at least two constructors where two of them are doing different
        //things. And display the result to the console.

        //This is a constructor with 0 parameters
        public ConstructorClass()
        {
            Console.WriteLine("This is ITUspkilling");
        }

        //This is a constructor with 2 parameters which are number1 and number2
        public ConstructorClass(int number1, int number2)
        {
            int total = number1 + number2;
            Console.WriteLine($"Addition of {number1} and {number2} = {total}");
        }        

    }
}
