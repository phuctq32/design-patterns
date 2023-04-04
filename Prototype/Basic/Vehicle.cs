using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Basic
{
    public abstract class Vehicle
    {
        private string brand;
        private string name;
        private string color;
        public string Brand { get => brand; set => brand = value; }
        public string Name { get => name; set => name = value; }
        public string Color { get => color; set => color = value; }

        public Vehicle() { }

        public Vehicle(Vehicle vehicle) 
        {
            this.brand = vehicle.brand;
            this.name = vehicle.name;
            this.color = vehicle.color;
        }

        public abstract Vehicle Clone();

        public virtual string ToString()
        {
            return "Brand: " + this.Brand + " | " + "Name: " + this.Name + " | " + "Color: " + this.Color;
        }
    }
}
