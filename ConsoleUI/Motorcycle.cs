using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        
        public Motorcycle() 
        {
            
        }

        public Motorcycle(string year, string make, string model, bool hasSideCart)
        {
            Year = year;
            Make = make;
            Model = model;
            HasSideCart = hasSideCart;
        }

        public bool HasSideCart { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine("It is a motorcycle.");
        }

        public override void DriveVirtual()
        {
            base.DriveVirtual();
        }
    }
}
