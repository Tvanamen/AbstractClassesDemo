using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public bool HasTrunk { get; set; }
        public int NumberSeats { get; set; }
        public Car()
        {

        }
        public override void DriveAbstract()
        {
            Console.WriteLine("This car is in drive!"); 
        }
    }
}
