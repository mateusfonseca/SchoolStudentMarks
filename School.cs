using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStudentMarks.Models
{
    public class School
    {
        public string Name { get; set; }

        public School(string _name)
        {
            Name = _name;
        }

        public override string ToString()
        {
            return $"School is {Name}.";
        }
    }
}
