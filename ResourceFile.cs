using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.PD46.C_.Lab5
{
    internal class ResourceFile
    {
        public string FileName { get; set; }
        public bool IsOpen { get; set; }
        public ResourceFile(string fileName)
        {
            FileName = fileName;
        }
        public void Open()
        {
            Console.WriteLine($"Opening file: {FileName}");
            IsOpen = true;
        }
        public string Read()
        {
            if (!IsOpen)
                throw new InvalidOperationException("File is not open.");
    
            return $"Reading from file: {FileName}";
        }

        public void Close()
        {
            if (IsOpen)
            {
                Console.WriteLine($"Closing file: {FileName}");
                IsOpen = false;
            }
        }
    }
}
