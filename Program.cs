using System;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an object of type IQuittable using the Employee class
            IQuittable employee = new Employee();

            //Call the Quit method using the interface object
            employee.Quit();

            //Keep the console window open
            Console.ReadLine();
        }
    }
}
