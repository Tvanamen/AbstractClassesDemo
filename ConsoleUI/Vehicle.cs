using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public int Year { get; set; } = 2000;
        public string Make { get; set; } = "Default make";
        public string Modle { get; set; } = "Default modle";

        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is in virtual drive");
        }
    }
}
