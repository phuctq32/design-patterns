using FactoryMethod.Coffee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.CoffeeShops
{
    internal abstract class CoffeeShop
    {
        public abstract ICoffee CreateCoffee(string type);

        public ICoffee OrderCoffee(string type)
        {
            ICoffee coffee = CreateCoffee(type);

            coffee.Prepare();
            coffee.Make();

            return coffee;
        }
    }
}
