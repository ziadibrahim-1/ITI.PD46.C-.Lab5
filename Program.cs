namespace ITI.PD46.C_.Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  Person Object Initializer
            //Person p = new Person
            //{
            //    FirstName = "John",
            //    LastName = "Doe",
            //    Age = 30,
            //    Address = new Address
            //    {
            //        City = "New York",
            //        Street = "5th Avenue"
            //    }
            //};
            //Console.WriteLine(p);
            #endregion

            #region Rectangle with Auto Properties
            //Rectangle r = new Rectangle(1)
            //{
            //    Width = 15,
            //    Height = 10,
            //    Color = "Red",
            //};
            //Console.WriteLine(r);
            #endregion

            #region Student Gradebook Indexer
            /// Gradebook g = new Gradebook(5);
            /// g[0]= 85.5;
            /// g[1]= 90.0;
            /// g[2]= 78.0;
            /// g[3]= 92.5;
            /// g[4]= 88.0;
            /// g[5]= 95.0; // This will throw an exception since the index is out of range
            /// لو انا بقا هعوز الف عليهم ب (for each) فانا لازم اعمل (implent IEnumrable) عشان جواها (method GetEnumrator) دي البتخليني اعرف الف ب for each
            /// Console.WriteLine($"Grade 1: {g[0]}");
            /// Console.WriteLine($"Grade 2: {g[1]}");
            /// Console.WriteLine($"Grade 3: {g[2]}");
            #endregion

            #region String Collection Indexer
            ///StringCollection Indexr = new StringCollection();
            ///Indexr[0] = "First";
            ///Indexr[1] = "Second";
            ///Console.WriteLine(Indexr[0]);
            ///Indexr["Server"]= "localhost";
            ///Indexr["Port"] = "8080";
            ///Console.WriteLine(Indexr["Server"]);
            #endregion

            #region Shopping Cart with ArrayList
            ShopingCart cart = new ShopingCart();
            cart.AddItem("Apple");
            cart.AddItem(1);
            cart.AddItem(3.14);
            cart.AddItem(DateTime.Now);
            cart.DisplayItems();
            cart.ReverseItems();
            Console.WriteLine("---------------------------");
            cart.DisplayItems();
            #endregion
        }
    }
}
