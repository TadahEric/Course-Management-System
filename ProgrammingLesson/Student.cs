using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingLesson
{
    //Below is a concept of inheritance where Student class (Subclass) has inherited from Person class (Superclass)
    class Student : Person 
    {
        //Task 37
        public string position = "Delegate";

        public Student(string firstName, string lastName, int age, string address) : base(firstName, lastName, age, address)
        {
        }

        public void StudentPosition()
        {
            Console.WriteLine("He is a " + position);
        }
    }
}
