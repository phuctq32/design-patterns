using FactoryMethod.Coffee;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.CoffeeShops
{
    internal class NorthernCoffeeShop : CoffeeShop
    {
        public override ICoffee CreateCoffee(string type)
        {
            if (type == "den")
            {
                return new NorthernBlackCoffee();
            }
            else if (type == "sua")
            {
                return new NorthernWhiteCoffee();
            }

            return null;
        }
    }
}
