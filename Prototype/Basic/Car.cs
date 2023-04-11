using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Basic
{
    public interface CarPrototype
    {
        Car Clone();
    }
    //public class Car : CarPrototype
    //{
    //    private string brand;
    //    private string name;
    //    private string color;
    //    public string Brand { get => brand; set => brand = value; }
    //    public string Name { get => name; set => name = value; }
    //    public string Color { get => color; set => color = value; }

    //    public Car() { }

    //    public Car(Car car)
    //    {
    //        car.Brand = this.Brand;
    //        car.Name = this.Name;
    //        car.Color = this.Color;
    //    }
    //    public Car Clone()
    //    {
    //        return new Car(this);
    //    }

    //    public string ToString()
    //    {
    //        return "Brand: " + this.Brand + " | " + "Name: " + this.Name + " | " + "Color: " + this.Color;
    //    }
    //}
    //internal class Car : ICloneable
    //{
    //    private string brand;
    //    private string name;
    //    private string color;
    //    public string Brand { get => brand; set => brand = value; }
    //    public string Name { get => name; set => name = value; }
    //    public string Color { get => color; set => color = value; }

    //    public Car() { }

    //    public object Clone()
    //    {
    //        Car car = new Car();
    //        car.Brand = this.Brand;
    //        car.Name = this.Name;
    //        car.Color = this.Color;
    //        return car;
    //    }

    //    public string ToString()
    //    {
    //        return "Brand: " + this.Brand + " | " + "Name: " + this.Name + " | " + "Color: " + this.Color;
    //    }
    //}

    public class Wheel
    {
        public Wheel() { }
    }

    public class Car : Vehicle
    {
        private int maxSpeed;
        private Wheel wheels;
        public int MaxSpeed { get => maxSpeed; set => maxSpeed = value; }
        public Wheel Wheels { get => wheels; set => wheels = value; }

        public Car() { }
        public Car(Car car)
            : base(car as Vehicle)
        {
            this.MaxSpeed = car.MaxSpeed;
            this.Wheels = new Wheel(); 
                        // car.wheels.Clone();
        }
        public override Vehicle Clone()
        {
            return new Car(this);
        }

        public override string ToString()
        {
            return base.ToString() + " | " + "Maximum Speed: " + this.MaxSpeed + " km/h";
        }
    }

    //public class Car
    //{
    //    private string brand;
    //    private string name;
    //    private string color;
    //    public string Brand { get => brand; set => brand = value; }
    //    public string Name { get => name; set => name = value; }
    //    public string Color { get => color; set => color = value; }

    //    public Car() { }

    //    public string ToString()
    //    {
    //        return "Brand: " + this.Brand + " | " + "Name: " + this.Name + " | " + "Color: " + this.Color;
    //    }
    //}
}
