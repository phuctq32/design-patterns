using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Table
{
    internal interface ITable
    {
        string GetName();
        double GetPrice();
    }
}
