using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties with object initializer syntax
             */
            var corvette = new Car()
            {
                Year = "1967",
                Make = "Chevrolet",
                Model = "Corvette",
                HasTrunk = true,
            };
            

            var harley = new Motorcycle() 
            {
                Year = "1985",
                Make = "Harley Davidson",
                Model = "Softail",
                HasSideCart = false,
            };


            Vehicle elDorado = new Car()
            {
                Year = "1971",
                Make = "Cadillac",
                Model = "El Dorado",
                HasTrunk = true
            };

            Vehicle ninja = new Motorcycle()
            {
                Year = "2017",
                Make = "Kawasaki",
                Model = "Ninja",
                HasSideCart = false
            };

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            vehicles.Add(corvette);
            vehicles.Add(harley);
            vehicles.Add(elDorado);
            vehicles.Add(ninja);

            foreach (var vehicle in vehicles) 
            {
                Console.WriteLine($"A {vehicle.Year} {vehicle.Make} {vehicle.Model}.");
                if (vehicle is Car car && car.HasTrunk)
                {
                    Console.WriteLine("It has a trunk.\n");
                }
                else if (vehicle is Motorcycle motorcycle && motorcycle.HasSideCart)
                {
                    Console.WriteLine("It has a side cart.\n");
                }
                else 
                {
                    Console.WriteLine("No additional features.\n");
                }

            }

            // Call each of the drive methods for one car and one motorcycle

            corvette.DriveAbstract();
            corvette.DriveVirtual();
            harley.DriveAbstract();
            harley.DriveVirtual();

            #endregion  
            Console.ReadLine();
        }
    }
}
