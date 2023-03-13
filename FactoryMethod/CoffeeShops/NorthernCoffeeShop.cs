using FactoryMethod.Coffee;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.CoffeeShops
{
    internal class SouthernCoffeeShop : CoffeeShop
    {
        public override ICoffee CreateCoffee(string type)
        {
            if (type == "den")
            {
                return new SouthernBlackCoffee();
            }
            else if (type == "sua")
            {
                return new SouthernWhiteCoffee();
            }

            return null;
        }
    }
}
