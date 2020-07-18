using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITUpskilling;




namespace ProgrammingLesson
{
    class Program
    {
        //The Main method below is an entry point to our program
        //Any code must be referenced from the Main method before it can work
        //This method has a few attributes like static (you cannot create an instance of it),
        //void (it won't return any values), has args as its parameter with array of string as a data type
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 4, 5, 6, 7, 8 };
            bool test = Convert.ToBoolean(numbers.FirstOrDefault(x => x.Equals(20)));
            string name = "Kola";

            //Task 1
            //Addition();
            //AdditionOption2();
            //AdditionOption3();

            //Task 2
            //AdditionOfAnyType();

            //Task 3
            //MultiplicationOfThreeNumbers();

            //Task 4
            //DivisionOfTwoNumbers();

            //Task 5
            //RemainderOfTwoNumbers();

            //Task 6
            //EvenOrOddNumberFinder();

            //Task 7
            //Write a computer program to display "Happy New Year" 9 times.
            //Use the Main method within the Program class to solve the problem and display the result to the console.
            //Console.WriteLine("1. Happy New Year");
            //Console.WriteLine("2. Happy New Year");
            //Console.WriteLine("3. Happy New Year");
            //Console.WriteLine("4. Happy New Year");
            //Console.WriteLine("5. Happy New Year");
            //Console.WriteLine("6. Happy New Year");
            //Console.WriteLine("7. Happy New Year");
            //Console.WriteLine("8. Happy New Year");
            //Console.WriteLine("9. Happy New Year");

            //Task 8
            //MethodOneToDisplayHNY();
            //MethodTwoToDisplayHNY();
            //MethodThreeToDisplayHNY();

            //Task 9
            //We need to create Objects the ClassOneToDisplayHNY,ClassTwoToDisplayHNY,ClassThreeToDisplayHNY
            //Object is an instance of a Class. A class is a blue print
            //ClassOneToDisplayHNY classOneToDisplayHNYObj = new ClassOneToDisplayHNY();
            //ClassTwoToDisplayHNY classTwoToDisplayHNYObj = new ClassTwoToDisplayHNY();
            //ClassThreeToDisplayHNY classThreeToDisplayHNYObj = new ClassThreeToDisplayHNY();
            //classOneToDisplayHNYObj.MethodOneFromClassOneToDisplayHNY();
            //classTwoToDisplayHNYObj.MethodTwoFromClassTwoToDisplayHNY();
            //classThreeToDisplayHNYObj.MethodThreeFromClassThreeToDisplayHNY();

            //Task 10
            //Write a computer program to create a class with at least two constructors where two of them are doing 
            //different things.And display the result to the console.
            // ConstructorClass constructorClassObj = new ConstructorClass();
            // 5 and 6 below are called Arguments i.e.values you give to a method or constructor that has parameters
            //ConstructorClass constructorClassObj = new ConstructorClass(5, 6);

            //Task 11
            //Option 1
            //Multiplication(2.2,4,6.6);

            //Task 11
            //Option 2
            //ClassOneToDisplayHNY classOneObj = new ClassOneToDisplayHNY();
            //classOneObj.MultiplicationOfThreeNumbers(3, 4, 5.5);

            //Task 12
            //ClassTwoToDisplayHNY classTwoObj = new ClassTwoToDisplayHNY();
            //double answer = classTwoObj.AdditionOfTwoNumbers(3, 4.4);
            //Console.WriteLine($"The new result after multiplication of {answer} by 3 = {answer * 3}");

            //Task 13
            //The same question has been treated in Task 12
            // The concept behind de-bugging i.e. steps into the written code one after the other at run time. Use both 'F10'
            //=> step over and 'F11' => step into keys to handle this concept 
            //Introduce a breakpoint i.e. a point at which code execution stops at run time
            //ClassTwoToDisplayHNY classTwoObj = new ClassTwoToDisplayHNY();
            //double answer = classTwoObj.AdditionOfTwoNumbers(3, 4.4);
            //Console.WriteLine($"The new result after multiplication of {answer} by 3 = {answer * 3}");

            //Task 13
            //Another task on debugging
            //int number1 = 3;
            //int number2 = 6;
            //int answer = number1 + number2;
            //Console.WriteLine("Addition of two numbers = " + answer);

            //Task 14
            //Option 1
            //AdditionOfTwoNumbers();

            //Task 14
            //Option 2
            //AdditionOfTwoInputs();

            //Task 15
            //CollectionOfStudentsWithArray();

            //Task 16
            //Option 1
            //ArrayOfStudentNames();

            //Task 16
            //Option 2
            //ArrayOfStudentNamesWithTryCatch();

            //Task 17
            //CollectionOfStudentsAge();

            //Task 18
            //ArrayOfStudentsAge();

            //Task 19
            //ListOfStudents();

            //Task 20
            //DataCollectionOfDifferentType();

            //Task 21
            //DataCollectionToPrintBoolean();

            //Temporary Test to know data type on a variable
            //NewTemporaryMethod();

            //Task 22
            //Option1
            //CodeRefactoringOption1();

            //Task 22
            //Option2
            //CodeRefactoringOption2();

            //Task 22
            //Option3
            //CodeRefactoringOption3();

            //Exercise 1 on LINQ
            //LinqExercise();

            //Task 23
            //StudentMarksManagement();

            //Task 24
            //DistinctionStudents();

            //Task 25
            //AverageStudents();

            //Task 26
            //Option1
            //NumberGenerator();

            //Task 26
            //Option2
            //SkipNumberGenerator();

            //Task 27
            //EvenNumberGenerator();

            //Task 28
            //BirthdayGenerator();

            //Task 29
            //BrowserSelection();

            //Task 30
            //ClassOneToDisplayHNY classOneObj = new ClassOneToDisplayHNY();
            //Above is an instance class and we are able to create an object of it. The object is called 'classOneObj'
            //Test.FullName();
            //Above is a static class. You cannot create an instance of it. 
            //Write the class name and have access to all its public members

            //Concept of Object Initializer
            //Option 1
            //ClassOneToDisplayHNY classOneObj = new ClassOneToDisplayHNY();
            //classOneObj.firstName = "Bayo";
            //classOneObj.lastName = "Adefisan";

            //Concept of Object Initializer
            //Option 2
            //ClassOneToDisplayHNY classOneObj2 = new ClassOneToDisplayHNY
            //{
            //    firstName = "Bayo",
            //    lastName = "Adefisan"
            //};

            //Task 31
            // The concept of class-level variable(s) and method level variable(s) 
            //Add a new class to the project to demonstrate this concept.
            //We are using 'Course' class for the solution

            //Task 32
            //StringManipulation();

            //Task 33
            //ReadDataFromNotePad();

            // Task 33
            //How to check if a string exists in Notepad file content
            //CheckIfAStringExists();

            //Task 34
            //WriteDataToNotepad();

            //Task 35
            //string connectionString = "Integrated Security=True;Initial Catalog=Test;Data Source=KOLADETIAMI19E6\\SQLEXPRESS";
            ////List<StudentModel> records = StudentRecordsSelection(connectionString);
            //var records = StudentRecordsSelection(connectionString);
            //foreach (var record in records)
            //{
            //    Console.WriteLine(record.StudentID + "|" + record.FirstName + "|" + record.LastName + "|" + record.Age + "|" + record.City);
            //}  

            //Task 36
            //string connectionString = "Integrated Security=True;Initial Catalog=Test;Data Source=KOLADETIAMI19E6\\SQLEXPRESS";
            //PopulateStudentTable(connectionString);

            //Task 37
            //Write a computer program to create three classes ('Person', 'Tutor' and 'Student') to deal with the followings. 
            //'Person' class has attributes 'firstName', 'lastName', 'age' and 'address'. 'Tutor' class has an attribute 'role'.
            //'Student' class has an attribute 'position'. Allow both 'Tutor' and 'Student' classes to inherit 'Person' class.
            //Create objects for both 'Tutor' and 'Student' classes and call their functions.
            //Tutor tutorObj = new Tutor("Kolade", "Tiamiyu", 35, "12 Connant Street");
            //tutorObj.PersonDetails();
            //tutorObj.Responsibility();

            //Student studentObj = new Student("Eric", "Tadar", 38, "49 Redman street");
            //studentObj.PersonDetails();
            //studentObj.StudentPosition();


            //Task 38  
            //Concept of Method Overloading
            //Write a computer program to create a new class called 'Arithmetic' to deal with the followings. It has 3 methods 
            //with the same name but different parameters or signatures. Allow each method to do the addition of two, 
            //three and four numbers respectively. Create an object of the class, call each method and provide the right 
            //number of arguments.
            //Arithmetic arithObj = new Arithmetic();
            //arithObj.Addition(5, 6, 7, 8);    //expected result = 26
            //arithObj.Addition(10, 20);        //expected result = 30  
            //arithObj.Addition(20, 30, 40);   //expected result = 90

            ////Task 38 Additional point to explain the concept of params
            //arithObj.Addition(2, 3, 4, 5, 5, 6, 7, 8, 8, 9, 9, 10); //expected result = 76

            //Task 39
            //Concept of Method Overriden
            //Create two new classes as Employee and PartTimeEmployee. Allow Employee class to have 
            //FirstName, LastName, DateOfBirth, Salary and Bonus Properties. And a method/function to implement the Bonus at 50%
            //Then allow PartTimeEmployee class to implement another method for Bonus calculation at 20%. 
            //Print the result to the console by creating an object of both Employee and PartTimeEmployee.
            //Employee employeeObj = new Employee();
            //employeeObj.BonusCalculation();
            //PartTimeEmployee ptEmpObj = new PartTimeEmployee();
            //ptEmpObj.BonusCalculation();

            //Task 40 
            //Concept of referencing or making use of a class that belongs to another Project
            //Create a new 'Class Library' Project and call it ITUpskilling. Create a new Class and call it 'Calculation'
            //Allow 'Calculation' class to have one method that can be used for addition. Then reference or call the
            //'Calculation' class from 'Program' class which belongs to 'ProgrammingLesson' project
            //Use this example to demonstrate different access modifiers
            //Calculation calcObj = new Calculation();
            //calcObj.Addition(1, 2, 3, 4);

            //Task 41
            //Concept of Interface
            //You cannot create an object of an Interface class
            //It can be used to implement empty method(s)
            //Use 'ITUpskilling' project to Create two Interfaces 'MSOffice' with three empty methods for 'File', 'Home', 'Insert'
            //and 'IPrint' with one method 'Print'
            //Then create three new classes for 'Word' 'Excel' and PowerPoint' to inherit 'MSOffice' interface
            //And allow only 'Word' class to inherit 'IPrint'

            //Task 42
            //Concept of Abstract Class
            //You cannot create an object of an abstract class
            //It can be used to implement empty method(s) and fully defined method(s)
            //Use 'ITUpskilling' project to Create an Abstract class called 'House' with five method where three of them
            //are empty methods ('NumberOfFloor', 'NumberOfRooms' and 'NumberOfToilets') and the remaining two methods are fully 
            //implemented and they are called 'MainEntrance' and 'ExitRoute'. 
            //Create two more classes 'Bungallow' and 'Terrace' to inherit abstract class 'House'

            //Task 43
            //enum
            //Create enum to represent months of the year, pick one of them and print it to the console
            //Console.WriteLine((int)Month.November);   //cast
            //Console.WriteLine(Convert.ToInt32(Month.November));
            //Console.WriteLine((int)Month.June);   //cast

            //Task 44
            //Struct or Structure
            //Create struct to manage book details
            //Books BiologyBook;
            //Books MathBook;
            //Books ChemistryBook;

            //BiologyBook.title = "Digestive System";
            //BiologyBook.author = "Lord Luggard";
            //BiologyBook.bookId = 111;

            //Console.WriteLine(BiologyBook.title);
            //Console.WriteLine(BiologyBook.author);
            //Console.WriteLine(BiologyBook.bookId);
        }

        //A few data types declaration
        static void TypesExplanation()
        {
            string firstName = "Bayo";
            int age = 45;
            double vat = 0.2;
            decimal vat2 = 0.2M;
            float vat3 = 0.2F;
            var vat4 = 0.2;
            bool isHeATeenager = false;
        }

        //A few operators in C-sharp
        //Addition (+), Substraction (-), Multiplication (*), Division (/), Modulo (%)
        //< (less than), > (greater than), = (assignment), == (equality or comparison) etc...

        //Task 1
        //Option 1
        //The concept behind variables declaration and data types.
        //Write a computer program to add two numbers. 
        //Display the result to the console
        //You will need 3 variables to solve the problem
        //We may end up using different data types like int (numbers), decimal
        static void Addition()
        {
            int firstNumber = 3;
            int secondNumber = 5;
            int total = firstNumber + secondNumber;
            Console.WriteLine("Addition of two numbers = " + total);
            //Concatenation concept was used above to manage data to be displayed to console
        }

        //Task 1
        //Option 2        
        static void AdditionOption2()
        {
            Console.WriteLine("Computer program to add two numbers");
            Console.WriteLine("Input the first number");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            int total = firstNumber + secondNumber;
            Console.WriteLine($"Addition of {firstNumber} and {secondNumber} = {total}");
            //String Interpolation concept was used above to manage data to be displayed to console
        }

        //Task 1
        //Option 3        
        static void AdditionOption3()
        {
            Console.WriteLine("Computer program to add two numbers");
            Console.WriteLine("Input the first number");
            long firstNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Input the second number");
            long secondNumber = Convert.ToInt64(Console.ReadLine());
            long total = firstNumber + secondNumber;
            Console.WriteLine($"Addition of {firstNumber} and {secondNumber} = {total}");            
        }

        //Task 2
        //Write a computer program to add two numbers of any 
        //type(double or integer). Display the result to the console.
        static void AdditionOfAnyType()
        {
            Console.WriteLine("Computer program to add two numbers");
            Console.WriteLine("Input the first number");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input the second number");
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            double total = firstNumber + secondNumber;
            Console.WriteLine($"Addition of {firstNumber} and {secondNumber} = {total}");            
        }

        //Task 3
        //Write a computer program to multiply three numbers of any type(decimal or integer). 
        //Display the result to the console.
        static void MultiplicationOfThreeNumbers()
        {
            Console.WriteLine("Computer program to multiply three numbers");
            Console.WriteLine("Input the first number");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input the second number");
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input the third number");
            double thirdNumber = Convert.ToDouble(Console.ReadLine());
            double total = firstNumber * secondNumber * thirdNumber;
            Console.WriteLine($"Multiplication of {firstNumber} , {secondNumber} and {thirdNumber} = {total}");
            Console.ReadLine();
        }

        //Task 4
        //Write a computer program to divide two numbers of any type (decimal or integer). 
        //Display the result to the console
        static void DivisionOfTwoNumbers()
        {
            Console.WriteLine("Computer program to divide two numbers");
            Console.WriteLine("Input the first number");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input the second number");
            double secondNumber = Convert.ToDouble(Console.ReadLine());         
            double answer = firstNumber / secondNumber;
            Console.WriteLine($"Division of {firstNumber} and {secondNumber} = {answer}");
        }

        //Task 5
        //Write a computer program to find a remainder of a division of two numbers.
        //Display the result to the console
        static void RemainderOfTwoNumbers()
        {
            Console.WriteLine("Computer program to find a remainder of two numbers");
            Console.WriteLine("Input the first number");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input the second number");
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            double remainder = firstNumber % secondNumber;
            Console.WriteLine($"Remainder of {firstNumber} divided by {secondNumber} = {remainder}");
        }

        //Task 6
        //If-statement implementation
        //Make use of code snippet
        //Write a computer program to ask a user to input a whole number.
        //Then tell the user if the inputted number is an 'even' or 'odd' number by displaying it to the console.
        //What is an even number?
        //Even number is a number that is divisible by 2 with remainder 0
        //number % 2 == 0 : this is to test for an even number. Computer takes the value of number at run time
        //and modulo it by 2. The remainder would then be compared to zero. If it's zero then it is an even number
        static void EvenOrOddNumberFinder()
        {
            Console.WriteLine("Computer program to find an even or an odd number");
            Console.WriteLine("input a whole number");
            //int number = Convert.ToInt16(Console.ReadLine());
            int number = Int16.Parse(Console.ReadLine());
            if (number % 2 == 0)     
            {
                Console.WriteLine($"{number} is an even number");
            }
            else if (number % 2 == 1)
            {
                Console.WriteLine($"{number} is an odd number");
            }
        }

        //Task 8
        //Write a computer program to display "Happy New Year" 9 times. Use 3 new methods within the Program Class to solve 
        //the problem and display the result to the console.
        static void MethodOneToDisplayHNY()
        {
            Console.WriteLine("1. Happy New Year");
            Console.WriteLine("2. Happy New Year");
            Console.WriteLine("3. Happy New Year");
        }

        //Task 8
        static void MethodTwoToDisplayHNY()
        {
            Console.WriteLine("4. Happy New Year");
            Console.WriteLine("5. Happy New Year");
            Console.WriteLine("6. Happy New Year");
        }

        //Task 8
        static void MethodThreeToDisplayHNY()
        {
            Console.WriteLine("7. Happy New Year");
            Console.WriteLine("8. Happy New Year");
            Console.WriteLine("9. Happy New Year");
        }

        //Task 11
        //Option1
        //Write a computer program to allow a method to take three parameters that can be used for multiplication within 
        //that method . And display the result to the console.
        //number1, number2, number3 are called Parameters
        static void Multiplication(double number1, double number2, double number3)
        {
            double answer = number1 * number2 * number3;
            Console.WriteLine("Multiplication of three numbers = " + answer);
        }

        //Task 14
        //Option 1
        //Write a computer program to add two numbers. At run time, give one or two strings as inputs and see 
        //if your code can manage it.
        //Implement try-catch to manage wrong input from end users
        static void AdditionOfTwoNumbers()
        {
            double firstNumber = 0;
            double secondNumber = 0;
            Console.WriteLine("Computer program to add two numbers");
            Console.WriteLine("Input the first number");
            try
            {
                firstNumber = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Input the second number");
                secondNumber = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }            
            double total = firstNumber + secondNumber;
            Console.WriteLine($"Addition of {firstNumber} and {secondNumber} = {total}");
        }

        //Task 14
        //Option 2
        static void AdditionOfTwoInputs()
        {
            try
            {
                Console.WriteLine("Computer program to add two numbers");
                Console.WriteLine("Input the first number");
                double firstNumber = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Input the second number");
                double secondNumber = Convert.ToDouble(Console.ReadLine());
                double total = firstNumber + secondNumber;
                Console.WriteLine($"Addition of {firstNumber} and {secondNumber} = {total}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Please input integer or decimal numbers");
            }            
        }

        //Task 15
        //Write a computer program that implements an array of string to hold 4 students. Give the student names at 
        //the point of declaration and print to the console those names
        //Array has a fixed lenght of data after declaration. That is, it cannot increased
        //Student names example = Rodrick, Nelson, Bola, Osa
        //Above names can be managed without collection (Array, List, Dictionary, ArrayList etc) as below
        //You cannot do Console.WriteLine only to see the data in a collection
        //You need to Loop through instead. You can implement foreach to achieve
        static void CollectionOfStudentsWithArray()
        {
            string[] studentNames = new string[] { "Rodrick", "Nelson", "Bola", "Osa" };
            foreach (var studentName in studentNames)
            {
                Console.WriteLine("Student name = " + studentName);
            }
        }
        
        //Task 16
        //Write a computer program that implements an array of string to hold 4 students.
        //Do not give the student names at the point of declaration.
        //Assign names to the array before printing those names to the console.
        //Array has a fixed lenght of data after declaration. That is, it cannot increased
        //Student names example = Rodrick, Nelson, Bola, Osa
        //Option 1 
        static void ArrayOfStudentNames()
        {            
            string[] studentNames = new string[4];
            studentNames[0] = "Rodrick";
            studentNames[1] = "Nelson";
            studentNames[2] = "Bola";
            studentNames[3] = "Osa";            
            foreach (var item in studentNames)
            {
                Console.WriteLine("Student name = " + item);
            }
        }

        //Task 16
        //Option2
        static void ArrayOfStudentNamesWithTryCatch()
        {
            try
            {
                string[] studentNames = new string[4];
                studentNames[0] = "Rodrick";
                studentNames[1] = "Nelson";
                studentNames[2] = "Bola";
                studentNames[3] = "Osa";
                studentNames[4] = "Joke";
                foreach (var item in studentNames)
                {
                    Console.WriteLine("Student name = " + item);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        //This is not recommended to manage group of data
        //Consider to use collection instead
        static void TemporaryMethod()
        {
            string firstStudent = "Rodrick";
            string secondStudent = "Nelson";
            string thirdStudent = "Bola";
            string fourthStudent = "Osa";
            Console.WriteLine(firstStudent);
            Console.WriteLine(secondStudent);
            Console.WriteLine(thirdStudent);
            Console.WriteLine(fourthStudent);
        }


        //Task 17
        //Write a computer program that implements an array of integers to hold 4 students age. 
        //Give their age at the point of declaration and print to the console those values.
        static void CollectionOfStudentsAge()
        {
            int[] studentsAge = new int[] { 45, 36, 33, 28};
            foreach (var age in studentsAge)
            {
                Console.WriteLine("Student age = " + age);
            }
        }

        //Task 18
        //Write a computer program that implements an array of integers to hold 4 students age. Give their age 
        //at the point of declaration and print to the console those values with more than or equal to 40
        static void ArrayOfStudentsAge()
        {
            int[] studentsAge = new int[4] { 45, 36, 33, 40 };            
            foreach (var age in studentsAge)
            {
                if (age >= 40)
                {
                    Console.WriteLine("Student age = " + age);
                }                
            }
        }

        //Task 19
        //Write a computer program that implements a List of string to hold students names. 
        //Allow the List to evolve. 
        //Firstly, print an empty list to the console. 
        //Secondly, provide a few student names and print them to the console. 
        //Thirdly, create a sub-list and add it to the main list and print everything to the console. 
        //Lastly, remove a few names from the list and print the rest to the console.
        static void ListOfStudents()
        {
            List<string> studentsName = new List<string>();
            //Print an empty list
            Console.WriteLine("First printing from the list");
            foreach (var name in studentsName)
            {
                Console.WriteLine("Student name = " + name);
            }
            //Provide a few student names
            studentsName.Add("Gbola");
            studentsName.Add("Olujide");
            studentsName.Add("Bayo");
            studentsName.Add("Dayo");
            //Print to the console
            Console.WriteLine("Second printing from the list");
            foreach (var name in studentsName)
            {
                Console.WriteLine("Student name = " + name);
            }
            //Create a sublist
            List<string> subList = new List<string>() { "Osa", "Femi", "Nelson", "Rooney", "Lampard" };
            //Add the above sublist to the main list which is "StudentsName"
            studentsName.AddRange(subList);
            //Print to the console
            Console.WriteLine("Third printing from the list");
            foreach (var name in studentsName)
            {
                Console.WriteLine("Student name = " + name);
            }
            //Remove a few names
            studentsName.Remove("Rooney");
            studentsName.Remove("Lampard");
            //Print to the console
            Console.WriteLine("Fourth printing from the list");
            foreach (var name in studentsName)
            {
                Console.WriteLine("Student name = " + name);
            }
        }

        //Task 20
        //Write a computer program that implements ArrayList and allow it to take different values 
        //(of different data types) and print the result to the console
        //Arraylist, as a type of collection, can be used to manage a set of data with different data types
        //For example, it can take combination of string, int, bool, decimal as opposed to both
        //Array and List which only take a set of data data with the same type (data type)
        static void DataCollectionOfDifferentType()
        {
            ArrayList listOfData = new ArrayList() {45, true, "Eric", 22.7};
            foreach (var item in listOfData)
            {
                Console.WriteLine("One of the data in the ArrayList = " + item);
            }
        }

        //Explanation on how to get a datatype printed from a variable
        static void NewTemporaryMethod()
        {
            int age = 40;
            string name = "Osa";
            double vat = 0.2;
            bool underage = true;
            Console.WriteLine(age.GetType().ToString());
            Console.WriteLine(name.GetType().ToString());
            Console.WriteLine(vat.GetType().ToString());
            Console.WriteLine(underage.GetType().ToString());
        }
        

        //Task 21
        //Write a computer program that implements ArrayList and allow it to take different values
        //(of different data types) and print only Boolean in the ArrayList to the console.
        static void DataCollectionToPrintBoolean()
        {
            ArrayList listOfData = new ArrayList() { 45, true, "Eric", 22.7, false, true };
            foreach (var item in listOfData)
            {
                if (item.GetType().ToString().Contains("Boolean"))
                {
                    Console.WriteLine("One of Booleans in the ArrayList = " + item);
                }                
            }
        }

        //Task 22
        //Write a computer program that implements a list of strings in 3 different ways
        //Print the result to console
        //Option 1
        static void CodeRefactoringOption1()
        {
            List<string> list = new List<string>() { "Eric", "Dayo", "Ogunleye", "Solance", "Rodrick" };
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        //Task 22
        //Write a computer program that implements a list of strings in 3 different ways
        //Print the result to console
        //Option 2
        static void CodeRefactoringOption2()
        {
            new List<string>() { "Eric", "Dayo", "Ogunleye", "Solance", "Rodrick" }.ForEach(item => Console.WriteLine(item));          
        }

        //Task 22
        //Write a computer program that implements a list of strings in 3 different ways
        //Print the result to console
        //Option 3
        static void CodeRefactoringOption3()
        {
            List<string> list = new List<string>() { "Eric", "Dayo", "Ogunleye", "Solance", "Rodrick" };
            list.ForEach(item => Console.WriteLine(item));
        }

        //Exercise on LINQ (Language Integrated Query)
        //select CourseName from Course where StudentID = 3;
        //print to the console all numbers that are greater than 3
        static void LinqExercise() 
        {
            int[] numbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
            var numberToPrint = from x in numbers where x > 3 select x;
            foreach (var item in numberToPrint)
            {
                Console.Write(item + ", ");
            }

            //Console.WriteLine("Same result with an if statement implementation");
            foreach (var item in numbers)
            {
                if (item > 3)
                {
                    Console.Write(item + ", ");
                }
            }            
        }

        //Task 23
        //Write a computer program to capture student names and their marks. 
        //Display to the console all captured students along with their marks.
        //Dictionary is a data structure that represents a collection of keys and values pair of data
        static void StudentMarksManagement()
        {
            Dictionary<string, int> studentResults = new Dictionary<string, int>();
            studentResults.Add("Bola", 60);
            studentResults.Add("Anjali", 65);
            studentResults.Add("Femi", 73);
            studentResults.Add("Joke", 70);
            studentResults.Add("Eric", 55);
            foreach (var item in studentResults)
            {
                Console.WriteLine("Student " + item.Key +" has a mark of "+ item.Value);                
            }
        }

        //Task 24
        //Write a computer program to capture student names and their marks.Display to the console only 
        //students with marks 70 and above.
        static void DistinctionStudents()
        {
            Dictionary<string, int> studentResults = new Dictionary<string, int>();
            studentResults.Add("Bola", 60);
            studentResults.Add("Anjali", 65);
            studentResults.Add("Femi", 73);
            studentResults.Add("Joke", 70);
            studentResults.Add("Eric", 55);
            studentResults.Add("Alex", 77);
            foreach (var item in studentResults)
            {
                if (item.Value >= 70)
                {
                    Console.WriteLine("Student " + item.Key + " has a mark of " + item.Value); 
                }                
            }
        }

        //Task 25
        //Write a computer program to capture student names and their marks. Display to the console only 
        //students with marks between 40 and 70.
        // && = AND statement (the second or subsequent conditions must be checked)
        // || = OR statement (the second or subsequent conditions must be checked)
        // & = AND statement (do not bother to check the second or subsequent conditions)
        // | = OR statement (do not bother to check the second or subsequent conditions)
        static void AverageStudents()
        {
            Dictionary<string, int> studentResults = new Dictionary<string, int>();
            studentResults.Add("Bola", 60);
            studentResults.Add("Anjali", 65);
            studentResults.Add("Femi", 73);
            studentResults.Add("Joke", 70);
            studentResults.Add("Rooney", 39);
            studentResults.Add("Eric", 55);
            studentResults.Add("Alex", 77);
            studentResults.Add("Lola", 40);
            foreach (var item in studentResults)
            {
                if (item.Value >= 40 && item.Value <= 70)                
                {
                    Console.WriteLine("Student " + item.Key + " has a mark of " + item.Value);
                }
            }
        }

        //Task 26
        //Option 1
        //Write a computer program to generate numbers between 1 and 20 to the console.
        // i++ means incrementor
        static void NumberGenerator()
        {
            for (int number = 1; number <= 20; number++)
            {
                Console.WriteLine(number);
            }
        }

        //Task 26
        //Write a computer program to generate numbers between 1 and 20 to the console.
        // i++ means incrementor
        static void SkipNumberGenerator()
        {
            for (int number = 1; number <= 20; number += 10)
            {
                Console.WriteLine(number);
            }
        }

        //Task 27
        //Write a computer program to generate numbers between 1 and 20. Only print to the console all even numbers.
        static void EvenNumberGenerator()
        {            
            for (int number = 1; number <= 20; number++)                
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(number);
                }                
            }
        }

        //Task 28
        //Write a computer program to print "Happy Birthday" 10 times
        //Implement while-statement to do it
        static void BirthdayGenerator()
        {
            int counter = 1;
            while (counter <= 10)
            {
                Console.WriteLine(counter + " Happy Birthday");
                counter++;
            }
        }

        //Task 29
        //Write a computer program to allow a user to input a browser name to decide a browser to use for test execution
        //Implement a switch-case statement
        static void BrowserSelection()
        {
            Console.WriteLine("Input a browser name. Let it be any of IE, Chrome or Firefox");
            string browser = Console.ReadLine().ToLower();
            switch (browser)
            {
                case "ie":
                    Console.WriteLine("This is Internet Explorer browser selection");
                    break;
                case "chrome":
                    Console.WriteLine("This is Google Chrome browser selection");
                    break;
                case "firefox":
                    Console.WriteLine("This is Firefox browser selection");
                    break;
                default:
                    Console.WriteLine("This is Safari browser selection");
                    break;
            }
        }

        //Task 32
        //Write a computer program to allow a user to input a string value and assign it to a variable. 
        //Use the declared variable for different things like contains, length, skip, clone, substring, 
        //remove etc to demonstrate string manipulation.
        //A user "Test Automation"
        static void StringManipulation()
        {
            Console.WriteLine("Input a text and press enter");
            string text = Console.ReadLine();
            Console.WriteLine(text.Contains("Auto")); //this should give true at run time
            Console.WriteLine(text.Contains("London")); //this should give false at run time
            Console.WriteLine(text.Length);  //this should give 15
            Console.WriteLine(text.Skip(5)); //this should give "Automation" //To be resolved 
            string newText = text.Clone().ToString();
            Console.WriteLine(newText); //This should give us "Test Automation"
            Console.WriteLine(text.Substring(0, 4));  //This should give "Test"
            Console.WriteLine(text.Substring(5, 10));  //This should give "Automation"
            Console.WriteLine(text.Remove(0, 5)); //This should give "Automation"
            Console.WriteLine(text.Remove(5, 10)); //This should give "Test"
            Console.WriteLine(text.ToUpper());
            Console.WriteLine(text.ToLower());
            Console.WriteLine(text.Trim());
        }

        //Task 33
        //Write a computer program to read data from a text file to the console
        static void ReadDataFromNotePad()
        {
            Console.WriteLine(File.ReadAllText(@"DataToRead.txt"));
        }

        //Task 33
        //Write a computer program to read data from a text file to the console
        //To check for a string in a file 
        static void CheckIfAStringExists()
        {
            Console.WriteLine(File.ReadAllText(@"DataToRead.txt").Contains("programmers who do it for fun"));  //true
            Console.WriteLine(File.ReadAllText(@"DataToRead.txt").Contains("The United Kingdom"));  //false
        }

        //Task 34
        //Write a computer program to write data from one text file to another text file.
        static void WriteDataToNotepad()
        {
            File.WriteAllText(@"DataWriting.txt", File.ReadAllText(@"DataToRead.txt"));
        }

        //Task 35
        //Write a computer program to fetch data from the 'Student' table within the 'Test' 
        //database in SQL Server Management Studio and display those records to the Console
        static List<StudentModel> StudentRecordsSelection(string connectionString)
        {
            List<StudentModel> studentRecords = new List<StudentModel>();
            string sqlQuery = "Select * from Student";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                connection.Open();

                using(SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        StudentModel record = new StudentModel();
                        record.StudentID = reader["StudentID"].ToString();
                        record.LastName = reader["LastName"].ToString();
                        record.FirstName = reader["FirstName"].ToString();
                        record.Age = reader["Age"].ToString();
                        record.City = reader["City"].ToString();
                        studentRecords.Add(record);
                    }
                    connection.Close();
                }
            }
            return studentRecords;
        }

        //Task 36
        //Write a computer program to populate data to 'Student' table within the 'Test' 
        //database in SQL Server Management Studio.
        static void PopulateStudentTable(string connectionString)
        {
            string query = @"Insert Into Student(FirstName,LastName,Age,City)
                             Values('Eric','Tadar',40,'Newcastle')";
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        //Task 43
        enum Month
        {
            January,        //0
            February,       //1
            March,          //2
            April, 
            May, 
            June, 
            July,
            August,
            September,
            October,
            November,
            December        //11
        }

        //Task 44
        struct Books
        {
            public string title;
            public string author;
            public int bookId;
        }
    }
}
