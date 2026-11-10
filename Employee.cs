using System;

namespace MainMethodAssignment
{
    //Create an Employee class that inherits the IQuittable interface
    public class Employee : IQuittable
    {
        //Implement the Quit method from the interface
        public void Quit()
        {
            //Display a message when the Quit method is called
            Console.WriteLine("Employee has quit.");
        }
    }
}
