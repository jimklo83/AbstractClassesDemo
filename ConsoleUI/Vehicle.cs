using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public string Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }



        public abstract void DriveAbstract();

        public virtual void DriveVirtual() 
        {
            Console.WriteLine("You are driving a virtual vehicle.");
        }

        
    }

}
