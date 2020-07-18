using System;

namespace ProgrammingLesson
{
    public class Course
    {
        //Task 31 solution  
        
        //Class level variables
        string firstName;
        string lastName;

        public void FullNameWithAGe()
        {
            int age = 35;  //this is a method level variable which is only accessible to this method only
            Console.WriteLine("His fullname is " + firstName + " " + lastName);
            Console.WriteLine("He's " + age + " years old");
        }

        public void FullName()
        {
            int age = 30;
            Console.WriteLine("His fullname is " + firstName + " " + lastName);
            Console.WriteLine("He's " + age + " years old");
        }        

    }
}