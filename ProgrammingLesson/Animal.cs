using System;

namespace ProgrammingLesson
{
    class Animal
    {
        //Variables
        public string firstName;
        public string lastName;

        //Task 9
        //Write a computer program to display "Happy New Year" 9 times. Use 3 new methods that belong to 3 different classes 
        //apart from Program Class to solve the problem. And display the result to the console.

        public void MethodOneFromClassOneToDisplayHNY()
        {
            Console.WriteLine("1. Happy New Year");
            Console.WriteLine("2. Happy New Year");
            Console.WriteLine("3. Happy New Year");
        }

        //Task 11
        //Option2
        //Write a computer program to allow a method to take three parameters that can be used for multiplication within 
        //that method . And display the result to the console.
        //number1, number2, number3 are called Parameters
        public void MultiplicationOfThreeNumbers(double number1, double number2, double number3)
        {
            Console.WriteLine($"{number1} * {number2} * {number3} = {number1 * number2 * number3}");

        }


        //A method does not only return common types like integer, bool, string  but also return an object (instance of a class)
        public Course Student()
        {
            //fills-in student form 
            //Click on submit button
            //A user should be directed to the course page
            return new Course();
        }

    }    
}
