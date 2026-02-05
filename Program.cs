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
            Rectangle r = new Rectangle(1)
            {
                Width = 15,
                Height = 10,
                Color = "Red",
            };
            Console.WriteLine(r);
            #endregion
        }
    }
}
