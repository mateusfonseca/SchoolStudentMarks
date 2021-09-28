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
            Console.WriteLine(student1.ToString());

            Subject subject1 = new Subject("English", 70);
            Console.WriteLine(subject1.ToString());
        }
    }
}
