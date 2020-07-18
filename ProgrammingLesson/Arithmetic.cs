using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingLesson
{
    //This is a concrete class. It is not a static class
    //Task 38
    //The concept of Overloading (under Polymorphism). Method overloading is a concept of having more then one methods
    //with the same name but different signatures. When this method is called or referenced, the supplied argument(s) will
    //determine the method that will called
    //Task 38
    //Write a computer program to create a new class called 'Arithmetic' to deal with the followings. It has 3 methods 
    //with the same name but different parameters or signatures. Allow each method to do the addition of two, 
    //three and four numbers respectively. Create an object of the class, call each method and provide the right 
    //number of arguments.
    class Arithmetic
    {
        public void Addition(int firstNumber, int secondNumber)
        {            
            Console.WriteLine($"Addition = {firstNumber + secondNumber}");
        }

        public void Addition(int firstNumber, int secondNumber, int thirdNumber)
        {
            Console.WriteLine($"Addition = {firstNumber + secondNumber + thirdNumber}");
        }

        public void Addition(int firstNumber, int secondNumber, int thirdNumber, int fourthNumber)
        {
            Console.WriteLine($"Addition = {firstNumber + secondNumber + thirdNumber + fourthNumber}");
        }

        public void Addition(params int[] numbers)
        {
            int total = 0;
            foreach (var number in numbers)
            {
                total = total + number;
                //total += number;
            }
            Console.WriteLine("Addition = " + total);
        }

    }
}
