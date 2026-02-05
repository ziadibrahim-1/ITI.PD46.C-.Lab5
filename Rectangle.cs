using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.PD46.C_.Lab5
{
    internal class Rectangle
    {
        public int Width { get; set; } = 10;
        public int Height { get; set; } = 5;
        public string Color { get; set; } = "Green";
        public string Unit { get; set; } = "cm";
        public int Id { get; }

        public double Area => Width * Height;

        public Rectangle(int _id)
        {
            Id = _id;
        }

        override public string ToString()
        {
            return $"Rectangle ID: {Id}, {Width} x {Height} {Unit}, Color: {Color}, Area: {Area} {Unit}²";
        }

    }
}
