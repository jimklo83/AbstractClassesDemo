using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
       
       
        public Car() 
        {
            
        }

        public Car(string year, string make, string model, bool hasTrunk)
        {
            Year = year;
            Make = make;
            Model = model;
            HasTrunk = hasTrunk;
        }
        public bool HasTrunk { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine("It is a car.");
        }
    }
}
