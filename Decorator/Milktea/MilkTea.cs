using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Milktea
{
    internal class MilkTea : IMilkTea
    {
        public double GetCost()
        {
            return 20000;
        }
    }
}
