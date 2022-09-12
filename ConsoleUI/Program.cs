using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             * DONE
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle DONE
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for MotorcycleDONE
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
                var vehicles = new List<Vehicle>();
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */
            Car colorado = new Car() { HasTrunk = false, Make = "Chevy", Modle = "Colorado", Year = 2022, NumberSeats = 5 };
            vehicles.Add(colorado);
            Motorcycle yamaha = new Motorcycle() { Year = 2002, Modle = "YZF-R6", Make = "Yamaha", BikeType = "Sports bike", HasSideCart = false };
            vehicles.Add(yamaha);
            Vehicle miniVan = new Car() { Year = 1999, Make = "Dodge", Modle = "Caravan", NumberSeats = 7 };
            vehicles.Add(miniVan);
            Vehicle sportsCar = new Car() { Year = 1969, Make = "Chevy", Modle = "Stingray", HasTrunk = true, NumberSeats = 2 };
            vehicles.Add(sportsCar);
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Make {vehicle.Make} Modle {vehicle.Modle} Year {vehicle.Year}  ");
                vehicle.DriveAbstract();
                vehicle.DriveVirtual();
                Console.WriteLine("-------------------------------");
            }

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle
            #endregion            
            Console.ReadLine();
        }
    }
}
