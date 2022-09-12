using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public bool HasSideCart { get; set; }
        public string BikeType { get; set; }
        public Motorcycle()
        {

        }
        public override void DriveAbstract()
        {
            Console.WriteLine("This motercycle is in drive!");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is a {GetType().BaseType.Name}is in virtual drive");
        }
    }
    
}
