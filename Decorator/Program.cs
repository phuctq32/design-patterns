using Decorator.Decorator;
using Decorator.Milktea;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMilkTea mt1 = new MilkTea();
            BubbleDecorator milkTea1 = 
                   new BubbleDecorator(
                       new BlackSugarDecorator(mt1));

            IMilkTea mt2 = new MilkTea();
            EggPuddingDecorator milkTea2 =
                new EggPuddingDecorator(
                    new BubbleDecorator(mt2));

            Console.WriteLine("Bubble Black Sugar Milk Tea: " + milkTea1.GetCost() + " VND");
            Console.WriteLine("Egg Pudding Bubble Milk Tea: " + milkTea2.GetCost() + " VND");
            Console.ReadLine();
        }
    }
}
