using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.PD46.C_.Lab5
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public double GPA { get; set; }

        public override string ToString()
        {
            return $"Student ID: {Id}, Name: {Name}, GPA: {GPA}";
        }
    }
}
