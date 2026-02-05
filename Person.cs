using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.PD46.C_.Lab5
{
    internal class Person
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Age { get; set; }
        public Address? Address { get; set; }

        override public string ToString()
        {
            string addressInfo = Address != null ? $"{Address.Street}, {Address.City}" : "No Address";
            return $"Name: {FirstName} {LastName}, Age: {(Age <= 0 ? "Invalid Age" : Age)}, Address: {Address?.Street?? "N/A"}, {Address?.City?? "N/A"}";
        }
    }
}
