using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.PD46.C_.Lab5
{
    internal class ShopingCart
    {
        ArrayList items = new ArrayList();

        public void AddItem(object item)
        {
            items.Add(item);
        }
        public void RemoveItem(object item)
        {
            items.Remove(item);
        }
        public void Clear()
        {
            items.Clear();
        }
        public void DisplayItems()
        {
            Console.WriteLine("Shopping Cart Items:");
            foreach (var item in items)
            {
                Console.WriteLine($"- {item}");
            }
        }
        public void SortItems()
        {
            try
            {
                items.Sort();
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Items cannot be sorted due to incompatible types.");
            }

        }
         public void ReverseItems()
        {
            items.Reverse();
        }

        public int Count
        {
            get { return items.Count; }
        }
        public bool Contains(object item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item), "Item cannot be null.");
            return items.Contains(item);
        }
        public int inddexof(object item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item), "Item cannot be null.");
            return items.IndexOf(item);
        }
        public void RemoveAt(int index)
        {
            if (index < 0 || index >= items.Count)
                throw new IndexOutOfRangeException("Index out of range.");
            items.RemoveAt(index);
        }

        public void insrtAt(int index, object item)
        {
            if (index < 0 || index > items.Count)
                throw new IndexOutOfRangeException("Index out of range.");
            items.Insert(index, item);
        }
    }
}
