using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Chair
{
    internal class WoodChair : IChair
    {
        public string GetName()
        {
            return "Ghe go";
        }

        public double GetPrice()
        {
            return 200000;
        }
    }
}
