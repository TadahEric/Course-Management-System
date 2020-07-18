using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingLesson
{
    //This is a Superclass to both student and tutor classes
    class Person
    {
        //Task 37
        //attributes 'firstName', 'lastName', 'age' and 'address'
        //public string firstName = "Eric";
        //public string lastName = "Tadar";
        //public int age = 36;
        //public string address = "10 Redman Street, Leeds";

        public Person(string firstName, string lastName, int age, string address)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Address = address;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public void PersonDetails()
        {
            Console.WriteLine("He is " + FirstName + " " + LastName);
            Console.WriteLine("He has been living at " + Address + " since he was " + Age + " years old");
        }
    }
}
