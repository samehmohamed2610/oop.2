using oop._2.properties;
using oop._2.Properties;

namespace oop._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Try all what we have learned in the lecture.

            #region Demo
            #region struct
            //Point p1;
            //p1 = new Point(5,10);
            //Console.WriteLine(p1.x);
            //Console.WriteLine(p1.y);
            //Console.WriteLine(p1);
            //Console.WriteLine(p1.ToString());
            #endregion

            #region Encapsulation
            //Employees employee = new Employee(20, "sameh elaraby", 50_000 ,20);

            //employee.SetId(30); //Seeter

            //employee.Name = "Mohamed Elaraby"; //Property set

            //employee.Salary = 19_000; //Property set

            //Console.WriteLine(employee.Name); //Property get

            //Console.WriteLine(employee.GetId()); // Getter 

            //Console.WriteLine(employee.Salary); //Property get

            ////Console.WriteLine(employee.ToString());
            #endregion

            #region Indexer
            //PhoneBook note = new PhoneBook(5);
            // note.Addperson(0 , "Hamza" , 01068836346);
            // note.Addperson(1 , "Adham" , 01012625859);
            // note.Addperson(2 , "Mostafa" , 01008781820);
            // note.Addperson(3 , "Sameh" , 01094140048);
            // note.Addperson(4 , "Elaraby" , 01151525618);

            // //note["Adham"] = 011111115111;
            // //Console.WriteLine(note["Adham"]);

            //// Console.WriteLine(note.GetNumber("Sameh"));

            // for (int i = 0; i <note.Size; i++)
            // {
            //     Console.WriteLine(note[i]);
            // }
            #endregion

            #endregion

            #endregion

            #region 1. Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.
            //Person1 person = new Person1(3);
            //person.Addperson(0, "Adham", 22);
            //person.Addperson(1, "Mostafa", 23);
            //person.Addperson(2, "Reda", 58);

            //for (int i = 0; i < person.Size; i++)
            //{
            //    Console.WriteLine(person[i]);
            //}
            #endregion

            #region 2. Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
            //Person persons = new Person(3);

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter details for person {i + 1}:");
            //    Console.Write("Name: ");
            //    string name = Console.ReadLine();

            //    int age;
            //    while (true)
            //    {
            //        Console.Write("Age: ");
            //        if (int.TryParse(Console.ReadLine(), out age) && age >= 0)
            //        {
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Invalid input. Please enter a valid age (non-negative integer).");
            //        }
            //    }

            //    persons[i] = (name, age);
            //}

            //var oldest = persons.FindOldest();

            //Console.WriteLine($"The oldest person is {oldest.Name}, Age: {oldest.Age}");
            #endregion

            #region 3.Design and implement a Class for the employees in a company:

            #region Employee Class to represent Employee data in a string Form
            //Employee employee = new Employee(1, "Am7", Permissions.developer, 60000, Gender.m, 1, 2, 2002);
            //Console.WriteLine(employee.ToString());
            #endregion

            #region Create an array of Employees 

            //    List<Employee> employees = new List<Employee>
            //{
            //    new Employee (2, "Am7", Permissions.dba, 60000, Gender.m, 3, 5, 2000),
            //    new Employee(3, "Hamo", Permissions.guest, 60000, Gender.m, 5, 3, 2010),
            //    new Employee(4, "security officer", (Permissions)15, 60000, Gender.m, 2, 2, 2002),
            //};

            //Array.ForEach(employees, p => Console.WriteLine($"Id : {p.Id} | Name : {p.Name} | Security_Level : {p.Security_Level}  | Salary :{p.Salary:c} | Gender : {(p.Gender.ToString() == Gender.m.ToString() ? " Male " : " Female ")} | Date :{p.Day}/{p.Month}/{p.Year}"));
            //for (int i = 0; i < 3; i++)
            //    Console.WriteLine(employees[i].ToString());
            #endregion

            #region Sort the employees

            //var sortedEmployees = employees.OrderBy(e => new DateOnly(e.Year, e.Month, e.Day)).ToList();


            //foreach (var employee in sortedEmployees)
            //{
            //    Console.WriteLine($"ID: {employee.Id}, Name: {employee.Name}, Date: {employee.Day}/{employee.Month}/{employee.Year}, Security Level: {employee.Security_Level}, Salary: {employee.Salary}, Gender: {employee.Gender}");
            //}

            #endregion

            #endregion


        }

    }

}
