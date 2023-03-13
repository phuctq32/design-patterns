using FactoryMethod.Coffee;
using FactoryMethod.CoffeeShops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class Program
    { 
        private static Random r = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Goi ca phe cho 5 nguoi o chi nhanh phia Bac: ");
            CoffeeShop nothernCoffeeShop = new NorthernCoffeeShop();
            for (int i = 0; i < 5; i++)
            {
                int n = r.Next(0, 2);
                ICoffee cf = nothernCoffeeShop.CreateCoffee(n == 0 ? "den" : "sua");
                Console.WriteLine("Nguoi thu " + (i + 1) + " uong " + cf.GetName());
            }

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Goi ca phe cho 5 nguoi o chi nhanh phia Nam: ");
            CoffeeShop southernCoffeeShop = new SouthernCoffeeShop();
            for (int i = 0; i < 5; i++)
            {
                int n = r.Next(0, 2);
                ICoffee cf = southernCoffeeShop.CreateCoffee(n == 0 ? "den" : "sua");
                Console.WriteLine("Nguoi thu " + (i + 1) + " uong " + cf.GetName());
            }
            Console.ReadKey();
        }
    }
}
