using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Table
{
    internal class PlasticTable : ITable
    {
        public string GetName()
        {
            return "Ban nhua";
        }

        public double GetPrice()
        {
            return 150000;
        }
    }
}
