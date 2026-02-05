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
            ///ShopingCart cart = new ShopingCart();
            ///cart.AddItem("Apple");
            ///cart.AddItem(1);
            ///cart.AddItem(3.14);
            ///cart.AddItem(DateTime.Now);
            ///cart.DisplayItems();
            ///cart.ReverseItems();
            ///Console.WriteLine("---------------------------");
            ///cart.DisplayItems();
            #endregion

            #region Generic Student List

            ///var student = new List<Student>
            ///{
            ///    new Student { Id = 1, Name = "Alice", GPA = 3.7 },
            ///    new Student { Id = 2, Name = "Bob", GPA= 4 },
            ///    new Student { Id = 3, Name = "Charlie", GPA = 2.2 },
            ///    new Student { Id = 4, Name = "David", GPA = 3.0 },
            ///    new Student { Id = 5, Name = "Eve", GPA = 3.9 },
            ///    new Student { Id = 6, Name = "Frank", GPA = 2.5 },
            ///};
            //foreach (var s in student)
            //{
            //    Console.WriteLine(s);
            //}
            //var student2 = student.Find(x => x.Id == 1);
            //var student2 = student.FirstOrDefault(x => x.Id == 15);

            //List<Student> student2 = student.FindAll(x => x.GPA > 3.5);

            //foreach (var s in student2)
            //{
            //    Console.WriteLine(s);
            //}

            //Sort

            //student.Sort((a,b) =>b.GPA.CompareTo(a.GPA));
            //foreach (var s in student)
            //{
            //    Console.WriteLine(s);
            //}

            //Console.WriteLine(student2);
            #endregion

            #region Calculator with Exceptions
            ///try
            ///{
            ///    Console.Write("Enter first number: ");
            ///    int input1 = int.Parse(Console.ReadLine());
            ///    Console.Write("Enter second number: ");
            ///    int input2 = int.Parse(Console.ReadLine());
            ///    double result = Calculator.Divide(input1, input2);
            ///    Console.Write(result);
            ///}
            ///catch (DivideByZeroException ex)
            ///{
            ///    Console.WriteLine($"Error: {ex.Message}");
            ///}
            ///catch (FormatException ex)
            ///{
            ///    Console.WriteLine($"Error: {ex.Message}");
            ///}
            ///catch (Exception ex)
            ///{
            ///    Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            ///}
            #endregion

            #region File Processor with Finally
            ResourceFile file = new ResourceFile("hamada.txt");
            try
            {
                file.Open();
                string content = file.Read();
                //throw new Exception("Simulated error while opening the file.");
                Console.WriteLine(content);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                file.Close();
            }

            #endregion
        }
    }
}
