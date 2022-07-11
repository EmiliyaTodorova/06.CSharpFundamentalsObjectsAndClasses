using System;
using System.Collections.Generic;

namespace _4.Students
{

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Student> students = new List<Student>();

            while (command != "end")
            {
                string[] splitParam = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string firstName = splitParam[0];
                string lastName = splitParam[1];    
                int age = int.Parse(splitParam[2]);
                string homeTown = splitParam[3];

                Student newStudent = new Student()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    HomeTown = homeTown,
                };
                students.Add(newStudent);

                command = Console.ReadLine();

            }
            string homeTownToSearch = Console.ReadLine();
            List<Student> filtredStudent = students.FindAll(x => x.HomeTown == homeTownToSearch);
            foreach(Student student in filtredStudent)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
            
        }
    }
}
