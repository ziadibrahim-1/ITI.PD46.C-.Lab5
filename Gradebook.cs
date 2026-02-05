using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.PD46.C_.Lab5
{
    internal class Gradebook
    {
        public double[] Grades { get; set; }
        public int Size { get; set; }

        public Gradebook(int size)
        {
            Size = size;
            Grades = new double[size];
        }
        public double this[int index]
        {
            get
            {
                if (index < 0 || index >= Size)
                    throw new IndexOutOfRangeException("Index out of range.");
                return Grades[index];
            }
            set
            {
                if (index < 0 || index >= Size)
                    throw new IndexOutOfRangeException("Index out of range.");
                Grades[index] = value;
            }
        }
    }
}
