using System;
using SchoolStudentMarks.Models;

namespace SchoolStudentMarks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello School!");

            School school1 = new School("Dorset College");
            Console.WriteLine(school1.ToString());

            Student student1 = new Student("Bruce Wayne");
            Student student2 = new Student("Peter Parker");

            Subject subject1 = new Subject("English", 70);
            Console.WriteLine(subject1.ToString());

            school1.listOfStudents.Add(student1);
            school1.listOfStudents.Add(student2);

            school1.DisplayStudents();
        }
    }
}
