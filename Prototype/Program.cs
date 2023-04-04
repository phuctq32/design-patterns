using Prototype.Basic;
using Prototype.PrototypeRegistry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Brand = "Vinfast";
            car1.Name = "V1";
            car1.Color = "Red";

            ////Not using Prototype Design Pattern
            //Car car2 = car1;

            //car1.Color = "Blue";
            //Console.WriteLine("car 1: " + car1.ToString());
            //Console.WriteLine("car 2: " + car2.ToString());

            //Using Prototype Design Pattern
            Car car3 = car1.Clone() as Car;

            car1.Color = "Blue";
            Console.WriteLine("car 1: " + car1.ToString());
            Console.WriteLine("car 3: " + car3.ToString());

            //VehicleManager vehicleManager = new VehicleManager();
            //List<Vehicle> vehicles = vehicleManager.GetByColor("Blue");

            //foreach (var vehicle in vehicles)
            //{
            //    Console.WriteLine(vehicle.ToString());
            //}

            Console.ReadLine();
        }
    }
}
