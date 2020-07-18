using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingLesson
{
    //Below is a concept of inheritance where Tutor class (Subclass) has inherited from Person class (Superclass)
    //In C sharp programming language, 1 class can only inherits from 1 other class but not from more than one classes
    //However, 1 class can inherit from multiple interface
    class Tutor : Person
    {
        //Task 37
        public string role = "Lecturer";

        public Tutor(string firstName, string lastName, int age, string address) : base(firstName, lastName, age, address)
        {
        }

        public void Responsibility()
        {
            Console.WriteLine("He works as a " + role);
        }
    }
}
