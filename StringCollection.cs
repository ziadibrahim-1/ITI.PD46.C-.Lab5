using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.PD46.C_.Lab5
{
    internal class StringCollection
    {
        List<string> items = new List<string>();
        Dictionary<string,string> Data = new Dictionary<string, string>();



        public string this[string key]
        {
            get
            {
                if (Data.ContainsKey(key))
                    return Data[key];
                else
                    return $"Key '{key}' not found.";
            }
            set
            {
                Data[key] = value;
            }
        }

        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= items.Count)
                    throw new IndexOutOfRangeException("Index out of range.");
                return items[index];
            }
            set
            {

                if (index < 0)
                    throw new IndexOutOfRangeException("Index out of range.");


                if (index < items.Count)
                {
                    items[index] = value;
                }

                else if (index == items.Count)
                {
                    items.Add(value);
                }
                else
                {
                    throw new IndexOutOfRangeException("Index must be sequential.");
                }
            }
        }
    }
}
