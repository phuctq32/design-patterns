using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Chair
{
    internal class PlasticChair : IChair
    {
        public string GetName()
        {
            return "Ghe nhua";
        }

        public double GetPrice()
        {
            return 80000;
        }
    }
}
