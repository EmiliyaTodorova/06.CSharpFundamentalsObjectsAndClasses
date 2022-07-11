using System;
using System.Collections.Generic;

namespace _5.Students_2._0
{

    class Student
    {
        public Student(string firstName, string lastName, int age, string homeTown)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeTown = homeTown;
        }

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

                bool doesStudentExsist = DoesStudentExsist(students,firstName, lastName);

                if (doesStudentExsist)
                {
                    Student exsistingStudent = GetExsistingStudent(students, firstName, lastName);
                    exsistingStudent.FirstName = firstName;
                    exsistingStudent.LastName = lastName;   
                    exsistingStudent.Age = age;
                    exsistingStudent.HomeTown = homeTown;

                }
                else
                {
                    Student newStudent = new Student(firstName, lastName, age, homeTown)
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        HomeTown = homeTown,
                    };
                    students.Add(newStudent);
                }
                    command = Console.ReadLine();

            }
            string homeTownToSearch = Console.ReadLine();
            List<Student> filtredStudent = students.FindAll(x => x.HomeTown == homeTownToSearch);
            foreach (Student student in filtredStudent)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }

        }

        static Student GetExsistingStudent(List<Student> students, string firstName, string lastName)
        {
            foreach(Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return student;
                }
            }
            return null;
        }

        static bool DoesStudentExsist(List<Student> students, string firstName, string lastName)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
