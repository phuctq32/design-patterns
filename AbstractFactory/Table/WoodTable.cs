using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Table
{
    internal class WoodTable : ITable
    {
        public string GetName()
        {
            return "Ban go";
        }

        public double GetPrice()
        {
            return 450000;
        }
    }
}
