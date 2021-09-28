using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStudentMarks.Models
{
    public class Student
    {
        public string Name { get; set; }

        public Student(string _name)
        {
            Name = _name;
        }

        public override string ToString()
        {
            return $"Student is {Name}.";
        }
    }
}
